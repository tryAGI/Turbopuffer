# CLAUDE.md -- Turbopuffer SDK

## Overview

Auto-generated C# SDK for [Turbopuffer](https://turbopuffer.com/) -- high-performance serverless vector database with namespaces, upsert, query, multi-query, and schema management.
OpenAPI spec from the official [turbopuffer/turbopuffer-openapi](https://github.com/turbopuffer/turbopuffer-openapi) repo.

## Build & Test

```bash
dotnet build Turbopuffer.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new TurbopufferClient(apiKey); // TURBOPUFFER_API_KEY env var
```

## Key Files

- `src/libs/Turbopuffer/openapi.yaml` -- OpenAPI spec (downloaded from turbopuffer/turbopuffer-openapi)
- `src/libs/Turbopuffer/generate.sh` -- Downloads spec, applies fixes, runs autosdk
- `src/libs/Turbopuffer/Generated/` -- **Never edit** -- auto-generated code
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- Spec uses Stainless conventions; `generate.sh` applies two fixes:
  1. **Path rename:** `?stainless_overload=multiQuery` query path converted to clean `/multi-query` path (Stainless overload convention not valid in C#)
  2. **Reserved keyword fix:** `AttributeSchema` anyOf inline -- original uses a variant named `string` (C# reserved keyword); renamed to `AttributeTypeName`
- Uses `--exclude-deprecated-operations` flag
- No sub-client pattern -- all operations are on the flat `TurbopufferClient`

## MEAI Integration

No MEAI interface (`IChatClient`, `IEmbeddingGenerator`, `ISpeechToTextClient`) is implemented -- Turbopuffer is a vector database with no matching MEAI interface.
