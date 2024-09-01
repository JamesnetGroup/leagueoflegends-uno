using Jamesnet.Core;
using Leagueoflegends.Clash.Local.Datas;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace Leagueoflegends.Clash.Local.ViewModels;

public class HubContentViewModel : ViewModelBase
{
    private readonly IScheduleDataLoader _scheduleDataLoader;
    private List<Schedule> _schedules;

    public HubContentViewModel(IScheduleDataLoader scheduleDataLoader)
    {
        _scheduleDataLoader = scheduleDataLoader;
        LoadSchedules();
    }

    public List<Schedule> Schedules
    {
        get =>  _schedules;
        set => SetProperty(ref _schedules, value);
    }

    private void LoadSchedules()
    {
        Schedules = _scheduleDataLoader.LoadSchedules();
    }
}
