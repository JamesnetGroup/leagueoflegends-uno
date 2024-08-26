using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.Datas;

public class PersonalChampStatsDataLoader : BaseResourceLoader<ChampionStats, List<ChampionStats>>, IPersonalChampStatsDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.PersonalChampStats.yml";

    public List<ChampionStats> LoadChampionStats() => LoadAndOrganize();

    public Dictionary<string, List<ChampionStats>> LoadChampionStatsGroupedByPosition()
    {
        var allChampions = LoadAndOrganize();
        return allChampions
            .GroupBy(c => c.Position)
            .ToDictionary(
                g => g.Key,
                g => g.OrderBy(c => c.Name).ToList()
            );
    }

    protected override IEnumerable<ChampionStats> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item => new ChampionStats
        {
            Seq = item.GetValue<int>("seq"),
            Name = item.GetValue<string>("name"),
            Mastery = item.GetValue<int>("mastery"),
            Achievements = item.GetValue<int>("achievements"),
            Position = item.GetValue<string>("position"),
            ImageUrl = $"ms-appx:///Leagueoflegends.Support/Images/portrait_{item.GetValue<string>("name").Replace(" ", "").Replace("&", "").Replace(".", "").Replace("'", "").ToLower()}.jpg"
        });
    }

    protected override List<ChampionStats> OrganizeItems(IEnumerable<ChampionStats> championStats)
    {
        return championStats.OrderBy(c => c.Seq).ToList();
    }
}
