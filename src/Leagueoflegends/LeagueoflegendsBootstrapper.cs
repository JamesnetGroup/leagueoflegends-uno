using Jamesnet.Core;
using Leagueoflegends.Main.Local.ViewModel;
using Leagueoflegends.Main.UI.Views;

namespace Leagueoflegends;

public class JamesVicky : IView2
{
    public string Name { get; set; }
}

public class LeagueOfLegendsBootstrapper : AppBootstrapper
{
    protected override void RegisterDependencies()
    {
        Container.RegisterSingleton<IView2, JamesVicky>();
        Container.RegisterSingleton<IView, MainContent>();

        // Layer와 View 간의 관계 설정
        var layerManager = Container.Resolve<ILayerManager>();
        var mainContent = Container.Resolve<MainContent>();
        layerManager.SetLayerViewMapping("MainLayer", mainContent);
    }

    protected override void RegisterViewModels()
    {
        ViewModelMapper.Register<MainContent, MainContentViewModel>();
    }
    protected override void OnStartup()
    {
    }
}

