using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.Datas;

public class FilterDataLoader : BaseResourceLoader<FilterOption, List<FilterOption>>, IFilterDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.FilterSortOptions.yml";

    public List<FilterOption> LoadOptions() => LoadAndOrganize();

    public List<FilterOption> GetByCategory(string category)
    {
        return LoadOptions().Where(x => x.Category == category).ToList();
    }

    protected override IEnumerable<FilterOption> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item => new FilterOption
        {
            Category = item.GetValue<string>("category"),
            Name = item.GetValue<string>("name"),
            IsSelected = item.GetValue<bool>("isSelected")
        });
    }

    protected override List<FilterOption> OrganizeItems(IEnumerable<FilterOption> options)
    {
        return options.ToList();
    }
}
