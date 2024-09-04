using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using Leagueoflegends.Support.Local.Services;

namespace Leagueoflegends.Clash.Local.ViewModels;

public class HubContentViewModel : ViewModelBase
{
    private readonly ISubMenuNavigator _subMenu;
    private readonly IScheduleDataLoader _scheduleData;

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

    public HubContentViewModel(ISubMenuNavigator subMenu, IScheduleDataLoader scheduleData)
    {
        _subMenu = subMenu;
        _scheduleData = scheduleData;
        LoadSchedules();
    }

    private void LoadSchedules()
    {
        TabMenus = _subMenu.GetSubMenuItems("HUB");
        CurrentTabMenu = TabMenus.FirstOrDefault();
        Schedules = _scheduleData.LoadSchedules();
    }
}
