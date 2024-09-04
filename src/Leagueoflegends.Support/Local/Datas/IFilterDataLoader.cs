using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface IFilterDataLoader
{
    List<FilterOption> LoadOptions();
    List<FilterOption> GetByCategory(string category);
}
