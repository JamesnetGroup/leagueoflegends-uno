# League of Legends Client (Uno-Platform)

[![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md)

This is a high-quality recreation project of the League of Legends client using the Uno Platform. The project showcases various implementation techniques of Uno and demonstrates a wide range of technical approaches to distributed design for large-scale projects.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnetgroup/leagueoflegends-uno.svg)](https://github.com/jamesnetgroup/leagueoflegends-uno/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnetgroup/leagueoflegends-uno.svg)](https://github.com/jamesnetgroup/leagueoflegends-uno/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnetgroup/leagueoflegends-uno.svg)](https://github.com/jamesnetgroup/leagueoflegends-uno/issues)

#### League of Legends XAML-Based Series:  
<div style="text-align: center;">
    <img src="https://jamesnetdev.blob.core.windows.net/articleimages/543a4bd8-ace3-4d1a-acab-36f5b7f8b200.png" width="8%"/>
    <img src="https://jamesnetdev.blob.core.windows.net/articleimages/0d8bd5b4-c898-4bcf-af91-b4267551934f.png" width="20%"/>
    <img src="https://jamesnetdev.blob.core.windows.net/articleimages/77eaa9cd-865b-430d-89c6-0e10ead0abd5.png" width="8%"/>
</div>

<br/>


[League of Legends Client (WPF)](https://github.com/jamesnetgroup/leagueoflegends-wpf)  
[League of Legends Client (Uno-Platform)](https://github.com/jamesnetgroup/leagueoflegends-uno)  
[League of Legends Client (OpenSilver)](https://github.com/jamesnetgroup/leagueoflegends-opensilver)  
[League of Legends Client (UWP)](https://github.com/JamesnetGroup/leagueoflegends-uwp)  
[League of Legends Client (WinUI 3)](https://github.com/jamesnetgroup/leagueoflegends-winui3)

<br/>

> If you are a WPF developer, you will see how naturally XAML-based WPF skills transition into cross-platform development.

## Project Overview

We have been researching and gaining experience with WPF technology since 2008. Over the years, various cross-platform technologies such as Xamarin, MAUI, Uno-Platform, AvaloniaUI, and OpenSilver have evolved, allowing us to extend the skills accumulated in WPF to the Uno-Platform.

This League of Legends Uno-Platform version we're releasing is built on the rich UX of XAML-based design from WPF, C#'s object-oriented design, and a systematic project structure. It's a new challenge following our previous [WPF version of League of Legends](https://github.com/jamesnetgorup/leagueoflegends-wpf) project.

This project demonstrates how to implement large-scale projects on the Uno-Platform. By implementing complex controls as CustomControls, we aim to provide developers with rich learning materials. Furthermore, it includes various technical implementation cases of Uno, showcasing how to utilize the powerful features of the Uno platform in real projects.

In particular, this project presents a broad approach to distributed design for large-scale applications. It demonstrates how to structure and manage complex applications through modularized structures, efficient state management, and scalable architecture.

The Jamesnet.Core framework library is designed based on .NET Standard 2.0 to work identically in both WPF and Uno. This library is provided as Jamesnet.Window for WPF and Jamesnet.Uno for the Uno-Platform.

In this project, we directly reference the actual source code of Jamesnet.Core and Jamesnet.Uno, allowing you to learn about the design methods of XAML-based frameworks.

We hope this project will be widely used not only in Uno-Platform and WPF but also in various XAML-based platforms such as MAUI, AvaloniaUI, OpenSilver, and WinUI3, opening new horizons for cross-platform development.

<img src="https://github.com/user-attachments/assets/3bc0d881-577e-4aa2-8802-698169d701a5" width="49%"/>
<img src="https://github.com/user-attachments/assets/d3b13869-d0f8-457d-90d9-5a637c500b4a" width="49%"/>
<img src="https://github.com/user-attachments/assets/45920f83-41b9-4924-8e92-86123d15a2a4" width="49%"/>
<img src="https://github.com/user-attachments/assets/4e41c4af-1a98-48b0-9c44-05ac48f0430e" width="49%"/>
<img src="https://github.com/user-attachments/assets/78415f9d-732c-4940-881c-beed7a6e9620" width="49%"/>
<img src="https://github.com/user-attachments/assets/b376f4ed-4ffd-4528-b1cc-6b0483f442e1" width="49%"/>
<img src="https://github.com/user-attachments/assets/3bc0d881-577e-4aa2-8802-698169d701a5" width="49%"/>
<img src="https://github.com/user-attachments/assets/0cedb504-2f27-43b8-87ed-34e85f1d7b83" width="49%"/>
<img src="https://github.com/user-attachments/assets/f5e80933-9d18-47c1-81c6-eb55a680972a" width="49%"/>
<img src="https://github.com/user-attachments/assets/d8aa51d5-c6e1-4a9a-95f8-e20a7c6f9f91" width="49%"/>
<img src="https://github.com/user-attachments/assets/c2cc6c22-8345-4333-83a2-61ab08883652" width="49%"/>
<img src="https://github.com/user-attachments/assets/fd6aa0ca-14c1-4446-b6cb-2617bc15b373" width="49%"/>
<img src="https://github.com/user-attachments/assets/be84fe63-4fb5-4a6c-a537-9907b88e648b" width="49%"/>
<img src="https://github.com/user-attachments/assets/24db2d8b-b839-42b2-be8a-2fc6266dad77" width="49%"/>
<img src="https://github.com/user-attachments/assets/642ccf0d-f2df-4adc-bb87-b1246cbda0b7" width="49%"/>
<img src="https://github.com/user-attachments/assets/bece2bfd-1bb9-436e-b928-929d3706398c" width="49%"/>

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
