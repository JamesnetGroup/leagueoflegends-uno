using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Tft.Local.ViewModels;

public class TftContentViewModel : ViewModelBase
{
    private readonly ITeamFightsDataLoader _teamFightsDataLoader;
    private List<TeamFight> _teamFights;

    public TftContentViewModel(ITeamFightsDataLoader teamFightsDataLoader)
    {
        _teamFightsDataLoader = teamFightsDataLoader;
        LoadTeamFights();
    }

    public List<TeamFight> TeamFights
    {
        get => _teamFights;
        set => SetProperty(ref _teamFights, value);
    }

    private void LoadTeamFights()
    {
        TeamFights = _teamFightsDataLoader.LoadTeamFights();
    }
}
