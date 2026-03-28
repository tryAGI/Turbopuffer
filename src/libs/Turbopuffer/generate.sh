#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/turbopuffer/turbopuffer-openapi/main/openapi.yml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/turbopuffer/turbopuffer-openapi/main/openapi.yml

# Fix 1: Rename the path with '?' (Stainless overload convention) to a clean path
# /v2/namespaces/{namespace}/query?stainless_overload=multiQuery -> /v2/namespaces/{namespace}/multi-query
yq -i '
  .paths["/v2/namespaces/{namespace}/multi-query"] = .paths["/v2/namespaces/{namespace}/query?stainless_overload=multiQuery"] |
  del(.paths["/v2/namespaces/{namespace}/query?stainless_overload=multiQuery"])
' openapi.yaml

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

autosdk generate openapi.yaml \
  --namespace Turbopuffer \
  --clientClassName TurbopufferClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
