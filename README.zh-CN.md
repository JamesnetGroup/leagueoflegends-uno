# 英雄联盟客户端 (Uno-Platform)

[![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md)

这是使用 Uno 平台重现的高质量英雄联盟客户端项目。该项目展示了 Uno 的各种实现技术，并演示了大规模项目分布式设计的广泛技术方法。

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnetgroup/leagueoflegends-uno.svg)](https://github.com/jamesnetgroup/leagueoflegends-uno/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnetgroup/leagueoflegends-uno.svg)](https://github.com/jamesnetgroup/leagueoflegends-uno/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnetgroup/leagueoflegends-uno.svg)](https://github.com/jamesnetgroup/leagueoflegends-uno/issues)

#### 英雄联盟 XAML 系列:  
[英雄联盟客户端 (WPF)](https://github.com/jamesnetgroup/leagueoflegends-wpf)  
[英雄联盟客户端 (Uno-Platform)](https://github.com/jamesnetgroup/leagueoflegends-uno)

> 如果您是 WPF 开发人员，您将看到基于 XAML 的 WPF 技术如何自然地过渡到跨平台开发。

## 项目概述

我们自 2008 年以来一直在研究和积累 WPF 技术经验。多年来，Xamarin、MAUI、Uno-Platform、AvaloniaUI 和 OpenSilver 等各种跨平台技术不断发展，使我们能够将在 WPF 中积累的技能扩展到 Uno-Platform。

我们发布的这个英雄联盟 Uno-Platform 版本是基于 WPF 的 XAML 丰富用户体验、C# 的面向对象设计以及系统化的项目结构构建的。这是继我们之前的 [WPF 版英雄联盟](https://github.com/jamesnetgorup/leagueoflegends-wpf)项目之后的新挑战。

本项目展示了如何在 Uno-Platform 上实现大规模项目。通过将复杂的控件实现为 CustomControls，我们旨在为开发人员提供丰富的学习材料。此外，它还包括 Uno 的各种技术实现案例，展示了如何在实际项目中利用 Uno 平台的强大功能。

特别是，该项目为大规模应用程序的分布式设计提供了广泛的方法。它通过模块化结构、高效的状态管理和可扩展的架构演示了如何构建和管理复杂的应用程序。

Jamesnet.Core 框架库基于 .NET Standard 2.0 设计，可在 WPF 和 Uno 中同样运行。该库在 WPF 中作为 Jamesnet.Window 提供，在 Uno-Platform 中作为 Jamesnet.Uno 提供。

在本项目中，我们直接引用了 Jamesnet.Core 和 Jamesnet.Uno 的实际源代码，使您能够学习基于 XAML 的框架的设计方法。

我们希望这个项目不仅能在 Uno-Platform 和 WPF 中广泛使用，还能在 MAUI、AvaloniaUI、OpenSilver 和 WinUI3 等各种基于 XAML 的平台中使用，为跨平台开发开辟新的视野。

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

## 支持的平台

本项目支持以下平台：

- **桌面**：在 Windows、macOS 和 Linux 上作为本地应用程序运行
- **Blazor WebAssembly**：使用 WebAssembly 技术在网络浏览器中运行（目前正在开发中）

注意：该应用程序主要为桌面环境开发。Blazor 支持尚未完成，将在未来更新中提供。更多详情请参阅下方的路线图。

## 如何运行

当您克隆此存储库时，它默认设置为 .NET 8.0 桌面环境。您可以在 Windows、macOS 或 Linux 上使用 Visual Studio 2022 或 JetBrains Rider 立即构建和运行它。

虽然此应用程序基于 Uno-Platform，但它主要为桌面环境设计。您可以从单一源代码创建一个在 Windows、macOS 和 Linux 上运行的单一程序。

### 桌面配置：

项目文件配置如下。您可以根据需要调整 .NET 版本。

```xml
<Project Sdk="Uno.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net8.0-desktop</TargetFrameworks>
  </PropertyGroup>
</Project>
```

'net8.0-desktop' 基于 Skia 库，支持 Windows、macOS 和 Linux。

### Blazor WebAssembly 配置：

> 注意：Blazor 支持目前正在开发中。Blazor 支持和网络托管功能将在未来更新中添加。

```xml
<Project Sdk="Uno.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net8.0-browserwasm;</TargetFrameworks>
  </PropertyGroup>
</Project>
```

我们欢迎对 Blazor 支持感兴趣的人贡献！

## 为项目做贡献

欢迎您的贡献！请随时提交拉取请求。

## 许可证

本项目采用 MIT 许可证。详情请参阅 [LICENSE](LICENSE) 文件。

## 开发路线图
以下是未来需要开发的项目。任何人都可以参与这些任务并成为贡献者。我们期待您的意见和参与！

- [ ] 将 GradientBrush 应用于 Foreground（参考：https://platform.uno/docs/articles/features/shapes-and-brushes.html）
- [ ] 更改 TextBox CaretBrush 颜色
- [ ] 改进 TextBox CustomControl
- [ ] 增强 ScrollViewer CustomControl
- [ ] 解决视图依赖注入过程中更改主窗口位置时视图坐标更新问题
- [ ] 改进 DependencyProperty 在 OnApplyTemplate 之前的 Callback 处理时机
- [ ] 添加多语言支持
- [ ] 实现多主题支持
- [ ] 改善 Blazor 支持的兼容性
- [ ] 整合 WPF/Uno、AvaloniaUI、OpenSilver 等跨平台框架（利用 Jamesnet.Core）
