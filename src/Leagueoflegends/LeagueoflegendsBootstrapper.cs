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
using Leagueoflegends.Clash.UI.Views;
using Leagueoflegends.Clash.Local.ViewModels;
using Leagueoflegends.Clash.Local.Datas;
using Leagueoflegends.Tft.Local.Datas;
using Leagueoflegends.Store.UI.Views;
using Leagueoflegends.Store.Local.Datas;
namespace Leagueoflegends;

public class LeagueOfLegendsBootstrapper : AppBootstrapper
{
    protected override void RegisterViewModels()
    {
        ViewModelMapper.Register<MainContent, MainContentViewModel>();
        ViewModelMapper.Register<OptionContent, OptionContentViewModel>();
        ViewModelMapper.Register<SocialContent, SocialContentViewModel>();
        ViewModelMapper.Register<SubMenuContent, SubMenuContentViewModel>();

        ViewModelMapper.Register<OverviewContent, OverviewContentViewModel>();
        ViewModelMapper.Register<ChampionsContent, ChampionsContentViewModel>();
        ViewModelMapper.Register<SkinsContent, SkinsContentViewModel>();
        ViewModelMapper.Register<SpellsContent, SpellsContentViewModel>();
        ViewModelMapper.Register<TftContent, TftContentViewModel>();
        ViewModelMapper.Register<HistoryContent, HistoryContentViewModel>();
        ViewModelMapper.Register<HubContent, HubContentViewModel>();
        ViewModelMapper.Register<StoreChampContent, StoreChampContentViewModel>();
    }

    protected override void RegisterDependencies()
    {
        Container.RegisterSingleton<IMenuManager, MenuManager>();

        Container.RegisterSingleton<IFriendDataLoader, FriendDataLoader>();
        Container.RegisterSingleton<IMenuDataLoader, MenuDataLoader>();
        Container.RegisterSingleton<IChampStatsDataLoader, ChampStatsDataLoader>();
        Container.RegisterSingleton<IFilterDataLoader, FilterDataLoader>();
        Container.RegisterSingleton<ISkinsDataLoader, SkinsDataLoader>();
        Container.RegisterSingleton<ISpellsDataLoader, SpellsDataLoader>();
        Container.RegisterSingleton<IMatchHistoryDataLoader, MatchHistoryDataLoader>();
        Container.RegisterSingleton<IPlayChampDataLoader, PlayChampDataLoader>();
        Container.RegisterSingleton<IRecentDataLoader, RecentDataLoader>();
        Container.RegisterSingleton<IScheduleDataLoader, ScheduleDataLoader>();
        Container.RegisterSingleton<ITeamFightsDataLoader, TeamFightsDataLoader>();
        Container.RegisterSingleton<IStoreChampDataLoader, StoreChampDataLoader>();

        Container.RegisterSingleton<IView, MainContent>();
        Container.RegisterSingleton<IView, SubMenuContent>();
        Container.RegisterSingleton<IView, OptionMenuContent>();
        Container.RegisterSingleton<IView, SocialContent>();

        Container.RegisterSingleton<IView, OptionContent>("OptionContent");
        Container.RegisterSingleton<IView, TftContent>("TftContent");
        Container.RegisterSingleton<IView, ShopContent>("ShopContent");
        Container.RegisterSingleton<IView, OverviewContent>("HomeOverviewContent");
        Container.RegisterSingleton<IView, HubContent>("ClashHubContent");
        Container.RegisterSingleton<IView, ChampionsContent>("CollectionChampionsContent");
        Container.RegisterSingleton<IView, SkinsContent>("CollectionSkinsContent");
        Container.RegisterSingleton<IView, SpellsContent>("CollectionSpellsContent");
        Container.RegisterSingleton<IView, HistoryContent>("ProfileMatchHistoryContent");
        Container.RegisterSingleton<IView, StoreChampContent>("StoreChampionsContent");
        Container.RegisterSingleton<IView, GeneralContent>("GeneralContent");

        IView mainContent = Container.Resolve<MainContent>();
        IView socialContent = Container.Resolve<SocialContent>();
        IView subMenuContent = Container.Resolve<SubMenuContent>();
        IView optionMenuContent = Container.Resolve<OptionMenuContent>();
        IView generalContent = Container.Resolve<GeneralContent>("GeneralContent");

        Layer.Mapping("MainLayer", mainContent);
        Layer.Mapping("SocialLayer", socialContent);
        Layer.Mapping("SubMenuLayer", subMenuContent);
        Layer.Mapping("OptionMenuLayer", optionMenuContent);
        Layer.Mapping("OptionContentLayer", generalContent);
    }

    protected override void OnStartup()
    {
    }
}

