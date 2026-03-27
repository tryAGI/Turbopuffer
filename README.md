# Turbopuffer

[![Nuget package](https://img.shields.io/nuget/vpre/Turbopuffer)](https://www.nuget.org/packages/Turbopuffer/)
[![dotnet](https://github.com/tryAGI/Turbopuffer/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Turbopuffer/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Turbopuffer)](https://github.com/tryAGI/Turbopuffer/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Turbopuffer OpenAPI specification](https://raw.githubusercontent.com/turbopuffer/turbopuffer-openapi/main/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Turbopuffer;

using var client = new TurbopufferClient(apiKey);
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Turbopuffer/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Turbopuffer/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
