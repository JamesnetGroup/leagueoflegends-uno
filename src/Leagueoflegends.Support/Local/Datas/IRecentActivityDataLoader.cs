using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface IRecentActivityDataLoader
{
    List<RecentActivity> LoadRecentActivities();
}
