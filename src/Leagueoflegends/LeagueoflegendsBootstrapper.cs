using Jamesnet.Core;
using Leagueoflegends.Main.UI.Views;
using Leagueoflegends.Social.UI.Views;
using Leagueoflegends.Tft.UI.Views;
using Leagueoflegends.Social.Local.ViewModels;
using Leagueoflegends.Home.UI.Views;
using Leagueoflegends.Home.Local.ViewModels;
using Leagueoflegends.Tft.Local.ViewModels;
using Leagueoflegends.Navigate.Local.ViewModels;
using Leagueoflegends.Navigate.UI.Views;
using Leagueoflegends.Support.Local.Services;
using Leagueoflegends.Navigate.Local.Services;
using Leagueoflegends.Main.Local.ViewModels;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Social.Local.Datas;
using Leagueoflegends.Navigate.Local.Datas;
using Leagueoflegends.Collection.UI.Views;
using Leagueoflegends.Collection.Local.ViewModels;
using Leagueoflegends.Collection.Local.Datas;
using Leagueoflegends.Shop.UI.Views;
using Leagueoflegends.Profile.UI.Views;
using Leagueoflegends.Profile.Local.ViewModels;
using Leagueoflegends.Profile.Local.Datas;
namespace Leagueoflegends;

public class LeagueOfLegendsBootstrapper : AppBootstrapper
{
    protected override void RegisterViewModels()
    {
        ViewModelMapper.Register<MainContent, MainContentViewModel>();
        ViewModelMapper.Register<SocialContent, SocialContentViewModel>();
        ViewModelMapper.Register<SubMenuContent, SubMenuContentViewModel>();

        ViewModelMapper.Register<OverviewContent, OverviewContentViewModel>();
        ViewModelMapper.Register<ChampionsContent, ChampionsContentViewModel>();
        ViewModelMapper.Register<SkinsContent, SkinsContentViewModel>();
        ViewModelMapper.Register<SpellsContent, SpellsContentViewModel>();
        ViewModelMapper.Register<TftContent, TftContentViewModel>();
        ViewModelMapper.Register<HistoryContent, HistoryContentViewModel>();
    }

    protected override void RegisterDependencies()
    {
        Container.RegisterSingleton<ISubMenuNavigator, SubMenuNavigator>();

        Container.RegisterSingleton<IFriendDataLoader, FriendDataLoader>();
        Container.RegisterSingleton<ISubMenuDataLoader, SubMenuDataLoader>();
        Container.RegisterSingleton<IPersonalChampStatsDataLoader, PersonalChampStatsDataLoader>();
        Container.RegisterSingleton<IFilterSortOptionsDataLoader, FilterSortOptionsDataLoader>();
        Container.RegisterSingleton<ISkinsDataLoader, SkinsDataLoader>();
        Container.RegisterSingleton<ISpellsDataLoader, SpellsDataLoader>();
        Container.RegisterSingleton<IMatchHistoryDataLoader, MatchHistoryDataLoader>();
        Container.RegisterSingleton<IPlayChampDataLoader, PlayChampDataLoader>();

        Container.RegisterSingleton<IView, MainContent>();
        Container.RegisterSingleton<IView, SubMenuContent>();
        Container.RegisterSingleton<IView, SocialContent>();

        Container.RegisterSingleton<IView, TftContent>("TftContent");
        Container.RegisterSingleton<IView, ShopContent>("ShopContent");
        Container.RegisterSingleton<IView, OverviewContent>("HomeOverviewContent");
        Container.RegisterSingleton<IView, ChampionsContent>("CollectionChampionsContent");
        Container.RegisterSingleton<IView, SkinsContent>("CollectionSkinsContent");
        Container.RegisterSingleton<IView, SpellsContent>("CollectionSpellsContent");
        Container.RegisterSingleton<IView, HistoryContent>("ProfileMatchHistoryContent");

        IView mainContent = Container.Resolve<MainContent>();
        IView subNavContent = Container.Resolve<SubMenuContent>();
        IView socialContent = Container.Resolve<SocialContent>();

        Layer.Mapping("MainLayer", mainContent);
        Layer.Mapping("SubNavLayer", subNavContent);
        Layer.Mapping("SocialLayer", socialContent);
    }

    protected override void OnStartup()
    {
    }
}

