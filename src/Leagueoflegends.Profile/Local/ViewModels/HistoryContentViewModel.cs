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

    private List<MatchHistory> _matchHistories;
    public List<MatchHistory> MatchHistories
    {
        get => _matchHistories;
        set => SetProperty(ref _matchHistories, value);
    }

    private MatchHistory _currentHistory;
    public MatchHistory CurrentHistory
    {
        get => _currentHistory;
        set => SetProperty(ref _currentHistory, value);
    }

    private List<PlayChamp> _playChamps;
    public List<PlayChamp> PlayChamps
    {
        get => _playChamps;
        set => SetProperty(ref _playChamps, value);
    }

    public HistoryContentViewModel(IMatchHistoryDataLoader matchHistoryDataLoader, IPlayChampDataLoader playChampDataLoader)
    {
        _matchHistoryDataLoader = matchHistoryDataLoader;
        _playChampDataLoader = playChampDataLoader;
        LoadData();
    }

    private void LoadData()
    {
        LoadMatchHistories();
        LoadPlayChamps();
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
}
