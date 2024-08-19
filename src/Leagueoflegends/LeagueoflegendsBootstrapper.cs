using Jamesnet.Core;
using Leagueoflegends.Main.Local.ViewModel;
using Leagueoflegends.Main.UI.Views;
using Leagueoflegends.Social.Local.Loaders;
using Leagueoflegends.Social.Local.ViewModels;
using Leagueoflegends.Social.UI.Views;
using Leagueoflegends.Support.Local.Models;
namespace Leagueoflegends;

public class LeagueOfLegendsBootstrapper : AppBootstrapper
{
    protected override void RegisterViewModels()
    {
        ViewModelMapper.Register<MainContent, MainContentViewModel>();
        ViewModelMapper.Register<SocialContent, SocialContentViewModel>();
    }

    protected override void RegisterDependencies()
    {
        Container.RegisterSingleton<IFriendsLoader, FriendsLoader>();
        Container.RegisterSingleton<IView, MainContent>();
        Container.RegisterSingleton<IView, SocialContent>();

        IView mainContent = Container.Resolve<MainContent>();
        IView socialContent = Container.Resolve<SocialContent>();

        Layer.SetLayerViewMapping("MainLayer", mainContent);
        Layer.SetLayerViewMapping("SocialLayer", socialContent);
    }

    protected override void OnStartup()
    {
    }
}

