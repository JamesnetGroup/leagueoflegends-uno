using Jamesnet.Core;
using Leagueoflegends.Main.Local.ViewModel;
using Leagueoflegends.Main.UI.Views;
using Leagueoflegends.Social.UI.Views;

namespace Leagueoflegends;

public class LeagueOfLegendsBootstrapper : AppBootstrapper
{
    protected override void RegisterDependencies()
    {
        Container.RegisterSingleton<IView, MainContent>();
        Container.RegisterSingleton<IView, SocialContent>();

        var layerManager = Container.Resolve<ILayerManager>();
        var mainContent = Container.Resolve<MainContent>();
        var socialContent = Container.Resolve<SocialContent>();
        layerManager.SetLayerViewMapping("MainLayer", mainContent);
        layerManager.SetLayerViewMapping("SocialLayer", socialContent);
    }

    protected override void RegisterViewModels()
    {
        ViewModelMapper.Register<MainContent, MainContentViewModel>();
    }

    protected override void OnStartup()
    {
    }
}

