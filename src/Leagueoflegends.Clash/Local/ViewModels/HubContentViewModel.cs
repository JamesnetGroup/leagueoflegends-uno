using Jamesnet.Core;
using Leagueoflegends.Clash.Local.Datas;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using Leagueoflegends.Support.Local.Services;
using System.Collections.Generic;
using System.ComponentModel;

namespace Leagueoflegends.Clash.Local.ViewModels;

public class HubContentViewModel : ViewModelBase
{
    private readonly ISubMenuNavigator _subMenuNavigator;
    private readonly IScheduleDataLoader _scheduleDataLoader;
    private SubMenuItem _currentTabMenu;
    private List<SubMenuItem> _tabMenus;
    private List<Schedule> _schedules;

    public SubMenuItem CurrentTabMenu
    {
        get => _currentTabMenu;
        set => SetProperty(ref _currentTabMenu, value);
    }

    public List<SubMenuItem> TabMenus
    {
        get => _tabMenus;
        set => SetProperty(ref _tabMenus, value);
    }

    public List<Schedule> Schedules
    {
        get => _schedules;
        set => SetProperty(ref _schedules, value);
    }

    public HubContentViewModel(ISubMenuNavigator subMenuNavigator, IScheduleDataLoader scheduleDataLoader)
    {
        _subMenuNavigator = subMenuNavigator;
        _scheduleDataLoader = scheduleDataLoader;
        LoadSchedules();
    }

    private void LoadSchedules()
    {
        TabMenus = _subMenuNavigator.GetSubMenuItems("HUB");
        CurrentTabMenu = TabMenus.FirstOrDefault();
        Schedules = _scheduleDataLoader.LoadSchedules();
    }
}
