using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.ViewModels;

public class SkinsContentViewModel : ViewModelBase
{
    private readonly ISkinsDataLoader _skinsData;
    private readonly IFilterDataLoader _filterData;

    private int _ownedSkinsCount;
    private FilterOption _selectedFilterOption;
    private FilterOption _selectedSortOption;
    private List<SkinGroup> _champions;
    private List<FilterOption> _filterOptions;
    private List<FilterOption> _sortOptions;

    public int OwnedSkinsCount
    {
        get => _ownedSkinsCount;
        set => SetProperty(ref _ownedSkinsCount, value);
    }

    public List<FilterOption> FilterOptions
    {
        get => _filterOptions;
        set => SetProperty(ref _filterOptions, value);
    }

    public FilterOption SelectedFilterOption
    {
        get => _selectedFilterOption;
        set => SetProperty(ref _selectedFilterOption, value);
    }
    public List<FilterOption> SortOptions
    {
        get => _sortOptions;
        set => SetProperty(ref _sortOptions, value);
    }

    public FilterOption SelectedSortOption
    {
        get => _selectedSortOption;
        set => SetProperty(ref _selectedSortOption, value);
    }

    public List<SkinGroup> Champions
    {
        get => _champions;
        set => SetProperty(ref _champions, value);
    }

    public SkinsContentViewModel(ISkinsDataLoader skinsData, IFilterDataLoader filterData)
    {
        _skinsData = skinsData;
        _filterData = filterData;
        InitializeViewModel();
    }

    private void InitializeViewModel()
    {
        LoadFilterAndSortOptions();
        LoadChampions();

        OwnedSkinsCount = Champions.Count;
    }

    private void LoadFilterAndSortOptions()
    {
        FilterOptions = _filterData.GetByCategory("ChampionFilter");
        SortOptions = _filterData.GetByCategory("ChampionSort");

        SelectedFilterOption = FilterOptions.FirstOrDefault();
        SelectedSortOption = SortOptions.FirstOrDefault();
    }

    private void LoadChampions()
    {
        var kvps = _skinsData.GetSkinsGroupedByName();
        Champions = new List<SkinGroup>(
            kvps.Select(kvp => new SkinGroup
            {
                Header = $"{kvp.Key} Collection",
                Children = kvp.Value.Where(skin => skin.IsPurchased).ToList()
            })
            .Where(group => group.Children.Any())
        );
    }
}
