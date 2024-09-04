using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.ViewModels;

public class ChampionsContentViewModel : ViewModelBase
{
    private int _proficiency;
    public int Proficiency
    {
        get => _proficiency;
        set => SetProperty(ref _proficiency, value);
    }

    private int _achieve;
    public int Achieve
    {
        get => _achieve;
        set => SetProperty(ref _achieve, value);
    }

    private List<FilterOption> _filterOptions;
    public List<FilterOption> FilterOptions
    {
        get => _filterOptions;
        set => SetProperty(ref _filterOptions, value);
    }

    private FilterOption _selectedFilterOption;
    public FilterOption SelectedFilterOption
    {
        get => _selectedFilterOption;
        set => SetProperty(ref _selectedFilterOption, value);
    }

    private List<FilterOption> _sortOptions;
    public List<FilterOption> SortOptions
    {
        get => _sortOptions;
        set => SetProperty(ref _sortOptions, value);
    }

    private FilterOption _selectedSortOption;
    public FilterOption SelectedSortOption
    {
        get => _selectedSortOption;
        set => SetProperty(ref _selectedSortOption, value);
    }

    private List<ChampionGroup> _champions;
    public List<ChampionGroup> Champions
    {
        get => _champions;
        set => SetProperty(ref _champions, value);
    }

    private readonly IChampStatsDataLoader _champData;
    private readonly IFilterDataLoader _filterData;

    public ChampionsContentViewModel(IChampStatsDataLoader champData, IFilterDataLoader filterData)
    {
        _champData = champData;
        _filterData = filterData;
        InitializeViewModel();
    }

    private void InitializeViewModel()
    {
        Proficiency = 282;
        Achieve = 343;
        LoadFilterAndSortOptions();
        LoadChampions();
    }

    private void LoadFilterAndSortOptions()
    {
        FilterOptions = _filterData.GetByCategory("FilterOptions");
        SortOptions = _filterData.GetByCategory("SortOptions");

        SelectedFilterOption = FilterOptions.FirstOrDefault();
        SelectedSortOption = SortOptions.FirstOrDefault();
    }

    private void LoadChampions()
    {
        var kvps = _champData.GetStatsByPosition();
        Champions = new List<ChampionGroup>(
            kvps.Select(kvp => new ChampionGroup
            {
                Header = kvp.Key,
                Children = kvp.Value
            })
        );
    }
}
