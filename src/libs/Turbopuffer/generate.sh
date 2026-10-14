#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://raw.githubusercontent.com/turbopuffer/turbopuffer-openapi/main/openapi.yml
install_autosdk_cli
temp_spec="$(mktemp)"
trap 'rm -f "$temp_spec"' EXIT
fetch_spec --fail --silent --show-error -L -o "$temp_spec" https://raw.githubusercontent.com/turbopuffer/turbopuffer-openapi/main/openapi.yml

# AutoSDK cannot yet generate valid identifiers for additional Stainless overload paths.
# Keep the last supported spec until the generator handles these paths correctly.
if yq -o=json '.paths | keys' "$temp_spec" |
    jq -e '[.[] | select(contains("?stainless_overload=") and . != "/v2/namespaces/{namespace}/query?stainless_overload=multiQuery")] | length == 0' >/dev/null; then
  mv "$temp_spec" openapi.yaml
else
  echo "Warning: unsupported Stainless overload paths in upstream spec; reusing checked-in spec." >&2
fi

# Fix 1: Rename the path with '?' (Stainless overload convention) to a clean path
# /v2/namespaces/{namespace}/query?stainless_overload=multiQuery -> /v2/namespaces/{namespace}/multi-query
if yq -e '.paths | has("/v2/namespaces/{namespace}/query?stainless_overload=multiQuery")' openapi.yaml >/dev/null; then
  yq -i '
    .paths["/v2/namespaces/{namespace}/multi-query"] = .paths["/v2/namespaces/{namespace}/query?stainless_overload=multiQuery"] |
    del(.paths["/v2/namespaces/{namespace}/query?stainless_overload=multiQuery"])
  ' openapi.yaml
fi

# Fix 2: Replace AttributeSchema anyOf to avoid generating a union variant named "string"
# (C# reserved keyword). The original anyOf has [AttributeType (string), AttributeSchemaConfig].
# We inline the string variant with title "AttributeTypeName" so the generated property
# name is "AttributeTypeName" instead of "string".
yq -i '
  .components.schemas.AttributeSchema.anyOf[0] = {
    "type": "string",
    "title": "AttributeTypeName",
    "description": "The data type of the attribute."
  }
' openapi.yaml

rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Turbopuffer \
  --clientClassName TurbopufferClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
