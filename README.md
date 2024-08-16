# League of Legends Client (Uno) [![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md) 

A high-fidelity recreation of the League of Legends client using Uno, showcasing advanced Uno techniques

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnet214/leagueoflegends-uno.svg)](https://github.com/jamesnet214/leagueoflegends-uno/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnet214/leagueoflegends-uno.svg)](https://github.com/jamesnet214/leagueoflegends-uno/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnet214/leagueoflegends-uno.svg)](https://github.com/jamesnet214/leagueoflegends-uno/issues)

## Project Overview
TBD...

## Supported Platforms

This project supports multiple platforms:

- **Blazor WebAssembly**: Run the application in web browsers using WebAssembly technology.
- **Desktop**: Run as a native desktop application.

## How to Run

### For Blazor WebAssembly:

```xml
<Project Sdk="Uno.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net8.0-browserwasm;</TargetFrameworks>
  </PropertyGroup>
</Project>
```

To run the Blazor WebAssembly version, use the appropriate command for your development environment. For example:

```
dotnet run --project YourProjectName.Wasm
```

### For Desktop:

```xml
<Project Sdk="Uno.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net8.0-desktop</TargetFrameworks>
  </PropertyGroup>
</Project>
```

To run the desktop version, use:

```
dotnet run --project YourProjectName.Desktop
```

Make sure you have the necessary .NET SDK and Uno Platform tools installed on your system before running the application.

## Color Table
- [x] 785A28:
- [x] 010A13:

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
