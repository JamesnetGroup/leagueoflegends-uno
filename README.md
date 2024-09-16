# League of Legends Client (Uno) [![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md) 

A high-fidelity recreation of the League of Legends client using Uno, showcasing advanced Uno techniques

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnet214/leagueoflegends-uno.svg)](https://github.com/jamesnet214/leagueoflegends-uno/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnet214/leagueoflegends-uno.svg)](https://github.com/jamesnet214/leagueoflegends-uno/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnet214/leagueoflegends-uno.svg)](https://github.com/jamesnet214/leagueoflegends-uno/issues)

## Project Overview

우리는 WPF를 적어도 2008년부터 WPF를 시작하여 오랜 시간 WPF 기술에 대해 연구하고 경험했으며 Xamarin, MAUI 그리고 Uno-Platform, AvaloniaUI, OpenSilver를 비롯한 다양한 크로스플랫폼으로의 기술 발전을 통해 오랫동안 축적해온 WPF 기술을 기반으로 Uno-Platform 플랫폼으로의 기술 확장을 할 수 있는 계기가 되었습니다. 또한 이 리그오브레전드 Uno-Platform 버전을 통해 WPF로부터 이어져온 XAML-Based 기반의 풍부한 UX와 C#의 훌륭한 객체지향적인 설계, 그리고 논리적인 프로젝트 분산화 설계 기술 노하우를 가지고 있는 우리의 경험을 바탕으로 WPF 버전의 리그오브레전드 버전에 이어 Uno-Platform 기반의 리그오브레전드 레포지터리를 공개하게 되었습니다.

이 프로젝트는 Uno-Platform에서 대규모 분산화 프로젝트를 하기 위한 아키텍트를 기반으로 복잡하고 구현하게 어려운 모든 세부 컨트트롤을 CustomControl 기반으로 구현하여, 풍부한 학습 자료가 되길 기대하는 마음으로 모든 구성이 잘 준비되어 있습니다. 또한 여러분은 WPF 버전의 리그오브레전드와도 함께 살펴볼 수 있으며, Jamesnet.Core 프레임워크 라이브러리는 WPF와 Uno에서 모두 100% 동일하게 동작할 수 있도록 .NET Standard 2.0 기반으로 설계되었으며 WPF, Uno-Platform에서 각각 Jamesnet.Window/Jamesnet.Uno를 통해 제공됩니다. 이 프로젝트에서는 누겟이 아닌 실제 Jamesnet.Core/Jamesnet.Uno 프로젝트와 소스코드가 직접 참조를 통해 포함되어 있어, 학습 과정에서도 XAML-Based 기반의 프레임워크 설계를 함께 배울 수 있도록 의도하고 있습니다.

이 프로젝트가 Uno-Platform과 WPF 뿐만 아니라 MAUI, AvaloniaUI, OpenSilver, WinUI3와 같은 XAML-Based 기반의 모든 플랫폼에서 폭넓게 기술이 공유될 수 있기를 기대합니다.

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

This project supports multiple platforms:

- **Desktop**: Run as a native desktop application. (Windows OS, MacOS, Linux)
- **Blazor WebAssembly**: Run the application in web browsers using WebAssembly technology. (이 애플리케이션은 Destop을 기준으로 개발되었기 때문에 현재 Blazor 구동을 위한 호환성 체크가 되어있지 않은 상태입니다. 향후 블레이저를 지원합니다. 자세한 사항은 하단의 로드맵을 참고해주세요.)

## How to Run

이 레포지터리를 최신으로 Clone을 통해 내려 받으면 기본 프레임워크 타겟이 .NET 8.0 데스크톱 기반으로 설정되어있습니다. 따라서 여러분은 윈도우 또는 MacOS 그리고 Linux에서 소스코드를 간단하게 내려받아 Visual Studio 2022 또는 JetBrains Rider 등으로 바로 빌드해 실행할 수 있습니다. 이 애플리케이션은 Uno-Platform 크로스플랫폼 중에서도 데스크톱을 기반으로 설계되었으며, 하나의 소스코드와 한 번의 빌드를 통해 윈도우, MacOS, Linux에서 동작하는 단일 프로그램입니다.

### For Desktop:

프로젝트를 내려 받으면 기본 타겟은 Desktop으로 지정되어 있습니다. 여러분의 닷넷 버전에 맞게 변경하는 것도 가능합니다.

```xml
<Project Sdk="Uno.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net8.0-desktop</TargetFrameworks>
  </PropertyGroup>
</Project>
```

.net8.0-desktop은 Skia 라이브러리 기반으로, Windows, MacOS, Linux를 기본적으로 포함합니다.

### For Blazor WebAssembly:

> 현재 아직은 Blazor에서 실행될 수 있도록 호환성 확인이 되어있지 않습니다. 따라서 향후 로드맵을 통해 Blaozr 지원 및 웹호스팅이 추가될 예정입니다. 

```xml
<Project Sdk="Uno.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net8.0-browserwasm;</TargetFrameworks>
  </PropertyGroup>
</Project>
```

이 부분에 대한 여러분의 기여와 요청이 필요합니다.

## Color Table (TBD)

향후 테마 제공을 위해 주요 색상 항목들을 관리할 리스트입니다.

- [x] 785A28:
- [x] 010A13:

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 로드맵
앞으로 향후 작업이 필요한 항목들에 대한 리스트입니다. 누구나 이 작업에 참여하고 기여자가 될 수 있습니다. 언제든지 요청해주세요. 당신과의 소통을 기대합니다.
- [ ] Foreground에서 GradientBrush 처리 (https://platform.uno/docs/articles/features/shapes-and-brushes.html)
- [ ] TextBox CaretBrush 색상 변경
- [ ] TextBox CustomControl 고도화
- [ ] ScrollViewer CustomControl 고도화
- [ ] 뷰 의존성 주입 과정에서 메인 윈도우 위치 변경시 뷰 좌표가 갱신되지 않는 현상 해결
- [ ] DependencyProperty OnApplyTemplate 이전에 Callback 처리 시점 해결
- [ ] 다국어 지원
- [ ] 멀티 테마 지원
- [ ] Blazor 지원을 위한 호환성 해결
- [ ] WPF/Uno, 그리고 AvaloniaUi, OpenSilver 등의 크로스플랫폼 프레임워크 통합 (Jamesnet.Core)
