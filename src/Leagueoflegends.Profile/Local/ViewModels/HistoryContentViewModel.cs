using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Profile.Local.ViewModels;

public class HistoryContentViewModel
{
    private readonly IMatchHistoryDataLoader _dataLoader;
    public List<MatchHistory> MatchHistories { get; private set; }
    public MatchHistory CurrentHistory { get; set; }

    public HistoryContentViewModel(IMatchHistoryDataLoader dataLoader)
    {
        _dataLoader = dataLoader;
        LoadMatchHistories();
    }

    private void LoadMatchHistories()
    {
        MatchHistories = _dataLoader.LoadMatchHistories();
        CurrentHistory = MatchHistories.FirstOrDefault();
    }
}
