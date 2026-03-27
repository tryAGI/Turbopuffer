# Authentication

The Turbopuffer SDK uses Bearer token authentication. You can obtain an API key from your [Turbopuffer dashboard](https://turbopuffer.com/dashboard).

## Basic Usage

```csharp
using Turbopuffer;

var client = new TurbopufferClient(apiKey: Environment.GetEnvironmentVariable("TURBOPUFFER_API_KEY")!);
```

## Environment Variable

| Variable | Description |
|----------|-------------|
| `TURBOPUFFER_API_KEY` | Your Turbopuffer API key |
