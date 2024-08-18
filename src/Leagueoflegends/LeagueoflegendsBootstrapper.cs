using Jamesnet.Core;
using Leagueoflegends.Main.Local.ViewModel;
using Leagueoflegends.Main.UI.Views;

namespace Leagueoflegends;

public class LeagueOfLegendsBootstrapper : AppBootstrapper
{
    protected override void RegisterDependencies()
    {
        Container.RegisterSingleton<IView, MainContent>();

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

