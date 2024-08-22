using Jamesnet.Core;
using Leagueoflegends.Main.Local.ViewModel;
using Leagueoflegends.Main.UI.Views;
using Leagueoflegends.Social.UI.Views;
using Leagueoflegends.Tft.UI.Views;
using Leagueoflegends.Social.Local.Loaders;
using Leagueoflegends.Social.Local.ViewModels;
using Leagueoflegends.Support.Local.Models;
using Leagueoflegends.Home.UI.Views;
using Leagueoflegends.Home.Local.ViewModels;
using Leagueoflegends.Tft.Local.ViewModels;
using Leagueoflegends.Navigate.Local.ViewModels;
using Leagueoflegends.Navigate.UI.Views;
namespace Leagueoflegends;

public class LeagueOfLegendsBootstrapper : AppBootstrapper
{
    protected override void RegisterViewModels()
    {
        ViewModelMapper.Register<MainContent, MainContentViewModel>();
        ViewModelMapper.Register<SocialContent, SocialContentViewModel>();
        ViewModelMapper.Register<HomeContent, HomeContentViewModel>();
        ViewModelMapper.Register<TftContent, TftContentViewModel>();
        ViewModelMapper.Register<SubNavContent, SubNavContentViewModel>();
    }

    protected override void RegisterDependencies()
    {
        Container.RegisterSingleton<IFriendsLoader, FriendsLoader>();
        Container.RegisterSingleton<IView, MainContent>();
        Container.RegisterSingleton<IView, SubNavContent>("HomeContent");
        Container.RegisterSingleton<IView, SocialContent>();
        Container.RegisterSingleton<IView, TftContent>("TftContent");
        Container.RegisterSingleton<IView, HomeContent>("HomeContent");

        IView mainContent = Container.Resolve<MainContent>();
        IView subNavContent = Container.Resolve<SubNavContent>();
        IView socialContent = Container.Resolve<SocialContent>();

        Layer.SetLayerViewMapping("MainLayer", mainContent);
        Layer.SetLayerViewMapping("UsbNavLayer", subNavContent);
        Layer.SetLayerViewMapping("SocialLayer", socialContent);
    }

    protected override void OnStartup()
    {
    }
}

