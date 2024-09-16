# League of Legends Client (Uno-Platform)

[![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md)

This is a high-quality recreation project of the League of Legends client using the Uno Platform. The project showcases various implementation techniques of Uno and demonstrates a wide range of technical approaches to distributed design for large-scale projects.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnet214/leagueoflegends-uno.svg)](https://github.com/jamesnet214/leagueoflegends-uno/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnet214/leagueoflegends-uno.svg)](https://github.com/jamesnet214/leagueoflegends-uno/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnet214/leagueoflegends-uno.svg)](https://github.com/jamesnet214/leagueoflegends-uno/issues)

## Project Overview

We have been researching and gaining experience with WPF technology since 2008. Over the years, various cross-platform technologies such as Xamarin, MAUI, Uno-Platform, AvaloniaUI, and OpenSilver have evolved, allowing us to extend the skills accumulated in WPF to the Uno-Platform.

This League of Legends Uno-Platform version we're releasing is built on the rich UX of XAML-based design from WPF, C#'s object-oriented design, and a systematic project structure. It's a new challenge following our previous [WPF version of League of Legends](https://github.com/jamesnetgorup/leagueoflegends-wpf) project.

This project demonstrates how to implement large-scale projects on the Uno-Platform. By implementing complex controls as CustomControls, we aim to provide developers with rich learning materials. Furthermore, it includes various technical implementation cases of Uno, showcasing how to utilize the powerful features of the Uno platform in real projects.

In particular, this project presents a broad approach to distributed design for large-scale applications. It demonstrates how to structure and manage complex applications through modularized structures, efficient state management, and scalable architecture.

The Jamesnet.Core framework library is designed based on .NET Standard 2.0 to work identically in both WPF and Uno. This library is provided as Jamesnet.Window for WPF and Jamesnet.Uno for the Uno-Platform.

In this project, we directly reference the actual source code of Jamesnet.Core and Jamesnet.Uno, allowing you to learn about the design methods of XAML-based frameworks.

We hope this project will be widely used not only in Uno-Platform and WPF but also in various XAML-based platforms such as MAUI, AvaloniaUI, OpenSilver, and WinUI3, opening new horizons for cross-platform development.

[16 images omitted for brevity]

## Supported Platforms

This project supports the following platforms:

- **Desktop**: Run as a native application on Windows, macOS, and Linux
- **Blazor WebAssembly**: Run in web browsers using WebAssembly technology (currently under development)

Note: This application is primarily developed for desktop environments. Blazor support is not yet complete and will be provided in future updates. Please refer to the roadmap below for more details.

## How to Run

When you clone this repository, it's set up for the .NET 8.0 desktop environment by default. You can build and run it immediately using Visual Studio 2022 or JetBrains Rider on Windows, macOS, or Linux.

While this application is based on the Uno-Platform, it's primarily designed for desktop environments. You can create a single program that works on Windows, macOS, and Linux from a single source code.

### Desktop Configuration:

The project file is configured as follows. You can adjust the .NET version as needed.

```xml
<Project Sdk="Uno.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net8.0-desktop</TargetFrameworks>
  </PropertyGroup>
</Project>
```

'net8.0-desktop' is based on the Skia library and supports Windows, macOS, and Linux.

### Blazor WebAssembly Configuration:

> Note: Blazor support is currently under development. Blazor support and web hosting features will be added in future updates.

```xml
<Project Sdk="Uno.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net8.0-browserwasm;</TargetFrameworks>
  </PropertyGroup>
</Project>
```

We welcome contributions from those interested in Blazor support!

## Contributing to the Project

Your contributions are welcome! Feel free to submit Pull Requests.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Development Roadmap
Here are the items that need development in the future. Anyone can participate in these tasks and become a contributor. We look forward to your opinions and participation!

- [ ] Apply GradientBrush to Foreground (Reference: https://platform.uno/docs/articles/features/shapes-and-brushes.html)
- [ ] Change TextBox CaretBrush color
- [ ] Improve TextBox CustomControl
- [ ] Enhance ScrollViewer CustomControl
- [ ] Resolve view coordinate update issue when changing main window position during view dependency injection
- [ ] Improve DependencyProperty Callback handling timing before OnApplyTemplate
- [ ] Add multi-language support
- [ ] Implement multi-theme support
- [ ] Improve compatibility for Blazor support
- [ ] Integrate cross-platform frameworks such as WPF/Uno, AvaloniaUI, OpenSilver (utilizing Jamesnet.Core)
