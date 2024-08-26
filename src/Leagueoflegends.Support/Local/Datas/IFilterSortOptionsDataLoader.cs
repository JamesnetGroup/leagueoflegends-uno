using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface IFilterSortOptionsDataLoader
{
    List<FilterOption> LoadOptions();
}
