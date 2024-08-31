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
    private readonly IRecentDataLoader _RecentDataLoader;

    private List<MatchHistory> _matchHistories;
    private MatchHistory _currentHistory;
    private List<PlayChamp> _playChamps;
    private List<Recent> _Recents;

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

    public List<Recent> Recents
    {
        get => _Recents;
        set => SetProperty(ref _Recents, value);
    }

    public HistoryContentViewModel(IMatchHistoryDataLoader matchHistoryDataLoader,
                                   IPlayChampDataLoader playChampDataLoader,
                                   IRecentDataLoader RecentDataLoader)
    {
        _matchHistoryDataLoader = matchHistoryDataLoader;
        _playChampDataLoader = playChampDataLoader;
        _RecentDataLoader = RecentDataLoader;
        LoadData();
    }

    private void LoadData()
    {
        LoadMatchHistories();
        LoadPlayChamps();
        LoadRecents();
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

    private void LoadRecents()
    {
        Recents = _RecentDataLoader.LoadRecents();
    }
}
