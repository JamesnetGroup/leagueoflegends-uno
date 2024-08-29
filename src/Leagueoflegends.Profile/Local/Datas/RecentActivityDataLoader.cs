using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Profile.Local.Datas;

public class RecentActivityDataLoader : BaseResourceLoader<RecentActivity, List<RecentActivity>>, IRecentActivityDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.RecentActivities.yml";

    public List<RecentActivity> LoadRecentActivities() => LoadAndOrganize();

    protected override IEnumerable<RecentActivity> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item => new RecentActivity
        {
            Concept = item.GetValue<string>("concept"),
            ActivePercent = item.GetValue<int>("activepercent")
        });
    }

    protected override List<RecentActivity> OrganizeItems(IEnumerable<RecentActivity> recentActivities)
    {
        return recentActivities.ToList();
    }
}
