using System.Collections.Generic;
using System.Linq;
using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Profile.Local.ViewModels;

public class HistoryContentViewModel : ViewModelBase
{
    private readonly IMatchHistoryDataLoader _matchHistoryDataLoader;
    private readonly IPlayChampDataLoader _playChampDataLoader;
    private readonly IRecentActivityDataLoader _recentActivityDataLoader;

    private List<MatchHistory> _matchHistories;
    private MatchHistory _currentHistory;
    private List<PlayChamp> _playChamps;
    private List<RecentActivity> _recentActivities;

    public List<MatchHistory> MatchHistories
    {
        get => _matchHistories;
        set => SetProperty(ref _matchHistories, value);
    }

    public MatchHistory CurrentHistory
    {
        get => _currentHistory;
        set => SetProperty(ref _currentHistory, value);
    }

    public List<PlayChamp> PlayChamps
    {
        get => _playChamps;
        set => SetProperty(ref _playChamps, value);
    }

    public List<RecentActivity> RecentActivities
    {
        get => _recentActivities;
        set => SetProperty(ref _recentActivities, value);
    }

    public HistoryContentViewModel(IMatchHistoryDataLoader matchHistoryDataLoader,
                                   IPlayChampDataLoader playChampDataLoader,
                                   IRecentActivityDataLoader recentActivityDataLoader)
    {
        _matchHistoryDataLoader = matchHistoryDataLoader;
        _playChampDataLoader = playChampDataLoader;
        _recentActivityDataLoader = recentActivityDataLoader;
        LoadData();
    }

    private void LoadData()
    {
        LoadMatchHistories();
        LoadPlayChamps();
        LoadRecentActivities();
    }

    private void LoadMatchHistories()
    {
        MatchHistories = _matchHistoryDataLoader.LoadMatchHistories();
        CurrentHistory = MatchHistories.FirstOrDefault();
    }

    private void LoadPlayChamps()
    {
        PlayChamps = _playChampDataLoader.LoadPlayChamps();
    }

    private void LoadRecentActivities()
    {
        RecentActivities = _recentActivityDataLoader.LoadRecentActivities();
    }
}
