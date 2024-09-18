# 리그 오브 레전드 클라이언트 (Uno-Platform)

[![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md)

Uno 플랫폼을 활용한 리그 오브 레전드 클라이언트의 고품질 재현 프로젝트입니다. 이 프로젝트는 Uno의 다양한 기술 구현에 대한 사례들을 포함하고 있으며, 대규모 프로젝트의 분산화 설계에 관한 폭넓은 기술적 접근을 보여줍니다.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnetgroup/leagueoflegends-uno.svg)](https://github.com/jamesnetgroup/leagueoflegends-uno/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnetgroup/leagueoflegends-uno.svg)](https://github.com/jamesnetgroup/leagueoflegends-uno/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnetgroup/leagueoflegends-uno.svg)](https://github.com/jamesnetgroup/leagueoflegends-uno/issues)

## 프로젝트 소개

저희는 2008년부터 WPF 기술을 연구하고 경험을 쌓아왔습니다. 그동안 Xamarin, MAUI, Uno-Platform, AvaloniaUI, OpenSilver 등 다양한 크로스 플랫폼 기술이 발전해 왔고, 이를 통해 WPF에서 축적한 기술을 Uno-Platform으로 확장할 수 있게 되었습니다.

이번에 공개하는 리그 오브 레전드 Uno-Platform 버전은 WPF에서 이어온 XAML 기반의 풍부한 UX, C#의 객체지향적 설계, 그리고 체계적인 프로젝트 구조를 바탕으로 만들어졌습니다. 이는 기존 [WPF 버전의 리그 오브 레전드](https://github.com/jamesnetgorup/leagueoflegends-wpf) 프로젝트에 이은 새로운 도전입니다.

이 프로젝트는 Uno-Platform에서 대규모 프로젝트를 구현하는 방법을 보여줍니다. 복잡한 컨트롤들을 CustomControl로 구현하여, 개발자들에게 풍부한 학습 자료를 제공하고자 합니다. 또한, Uno의 다양한 기술 구현 사례를 포함하고 있어, Uno 플랫폼의 강력한 기능들을 실제 프로젝트에서 어떻게 활용할 수 있는지 보여줍니다.

특히 이 프로젝트는 대규모 애플리케이션의 분산화 설계에 대한 폭넓은 접근 방식을 제시합니다. 모듈화된 구조, 효율적인 상태 관리, 그리고 확장 가능한 아키텍처를 통해 복잡한 애플리케이션을 어떻게 구조화하고 관리할 수 있는지 보여줍니다.

Jamesnet.Core 프레임워크 라이브러리는 WPF와 Uno에서 동일하게 동작하도록 .NET Standard 2.0 기반으로 설계되었습니다. 이 라이브러리는 WPF에서는 Jamesnet.Window로, Uno-Platform에서는 Jamesnet.Uno로 제공됩니다.

이 프로젝트에서는 Jamesnet.Core와 Jamesnet.Uno의 실제 소스 코드를 직접 참조하고 있어, XAML 기반 프레임워크의 설계 방식도 함께 학습할 수 있습니다.

우리는 이 프로젝트가 Uno-Platform과 WPF뿐만 아니라 MAUI, AvaloniaUI, OpenSilver, WinUI3 같은 다양한 XAML 기반 플랫폼에서도 널리 활용되어, 크로스 플랫폼 개발의 새로운 지평을 열기를 바랍니다.

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

## 지원 플랫폼

이 프로젝트는 다음 플랫폼을 지원합니다:

- **데스크톱**: Windows, macOS, Linux에서 네이티브 애플리케이션으로 실행
- **Blazor WebAssembly**: 웹 브라우저에서 WebAssembly 기술을 통해 실행 (현재 개발 중)

참고: 현재 이 애플리케이션은 데스크톱 환경을 중심으로 개발되었습니다. Blazor 지원은 아직 완벽하지 않으며, 향후 업데이트를 통해 제공될 예정입니다. 자세한 내용은 아래의 로드맵을 참고해 주세요.

## 실행 방법

이 저장소를 클론하면 기본적으로 .NET 8.0 데스크톱 환경으로 설정되어 있습니다. Windows, macOS, Linux 어느 환경에서든 Visual Studio 2022나 JetBrains Rider를 사용해 바로 빌드하고 실행할 수 있습니다.

이 애플리케이션은 Uno-Platform을 기반으로 하지만, 주로 데스크톱 환경을 위해 설계되었습니다. 하나의 소스 코드로 Windows, macOS, Linux에서 모두 동작하는 단일 프로그램을 만들 수 있습니다.

### 데스크톱용 설정:

프로젝트 파일에서 다음과 같이 설정되어 있습니다. 필요에 따라 .NET 버전을 조정할 수 있습니다.

```xml
<Project Sdk="Uno.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net8.0-desktop</TargetFrameworks>
  </PropertyGroup>
</Project>
```

'net8.0-desktop'은 Skia 라이브러리를 기반으로 하며, Windows, macOS, Linux를 모두 지원합니다.

### Blazor WebAssembly용 설정:

> 주의: 현재 Blazor 지원은 개발 중입니다. 향후 업데이트를 통해 Blazor 지원 및 웹 호스팅 기능이 추가될 예정입니다.

```xml
<Project Sdk="Uno.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net8.0-browserwasm;</TargetFrameworks>
  </PropertyGroup>
</Project>
```

Blazor 지원에 관심 있는 분들의 기여를 환영합니다!

## 프로젝트에 기여하기

여러분의 기여를 환영합니다! 자유롭게 Pull Request를 제출해 주세요.

## 라이선스

이 프로젝트는 MIT 라이선스를 따릅니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 개발 로드맵
앞으로 개발이 필요한 항목들입니다. 누구나 이 작업에 참여하고 기여할 수 있습니다. 여러분의 의견과 참여를 기다립니다!

- [ ] Foreground에 GradientBrush 적용 (참고: https://platform.uno/docs/articles/features/shapes-and-brushes.html)
- [ ] TextBox의 CaretBrush 색상 변경
- [ ] TextBox CustomControl 개선
- [ ] ScrollViewer CustomControl 개선
- [ ] 뷰 의존성 주입 과정에서 메인 윈도우 위치 변경 시 뷰 좌표 갱신 문제 해결
- [ ] DependencyProperty의 OnApplyTemplate 이전 Callback 처리 타이밍 개선
- [ ] 다국어 지원 추가
- [ ] 다중 테마 지원 구현
- [ ] Blazor 지원을 위한 호환성 개선
- [ ] WPF/Uno, AvaloniaUI, OpenSilver 등 크로스 플랫폼 프레임워크 통합 (Jamesnet.Core 활용)
