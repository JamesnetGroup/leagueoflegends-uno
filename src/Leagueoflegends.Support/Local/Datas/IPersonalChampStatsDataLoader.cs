using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface IPersonalChampStatsDataLoader
{
    List<ChampionStats> LoadChampionStats();
    Dictionary<string, List<ChampionStats>> LoadChampionStatsGroupedByPosition();
}
