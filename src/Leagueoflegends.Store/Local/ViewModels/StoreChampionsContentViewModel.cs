using Jamesnet.Core;
using System.Collections.ObjectModel;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.ViewModels;

public class StoreChampionsContentViewModel : ViewModelBase
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

    private ObservableCollection<FilterOption> _filterOptions;
    public ObservableCollection<FilterOption> FilterOptions
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

    private ObservableCollection<FilterOption> _sortOptions;
    public ObservableCollection<FilterOption> SortOptions
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

    private ObservableCollection<ChampionGroup> _champions;
    public ObservableCollection<ChampionGroup> Champions
    {
        get => _champions;
        set => SetProperty(ref _champions, value);
    }

    private readonly IPersonalChampStatsDataLoader _champDataLoader;
    private readonly IFilterSortOptionsDataLoader _optionsDataLoader;

    public StoreChampionsContentViewModel(IPersonalChampStatsDataLoader champDataLoader, IFilterSortOptionsDataLoader optionsDataLoader)
    {
        _champDataLoader = champDataLoader;
        _optionsDataLoader = optionsDataLoader;
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
        var filters = _optionsDataLoader.LoadOptions().Where(x => x.Category == "FilterOptions");
        var options = _optionsDataLoader.LoadOptions().Where(x => x.Category == "SortOptions");
        FilterOptions = new ObservableCollection<FilterOption>(filters);
        SortOptions = new ObservableCollection<FilterOption>(options);
        SelectedFilterOption = FilterOptions.FirstOrDefault();
        SelectedSortOption = SortOptions.FirstOrDefault();
    }

    private void LoadChampions()
    {
        var groupedChampions = _champDataLoader.LoadChampionStatsGroupedByPosition();
        Champions = new ObservableCollection<ChampionGroup>(
            groupedChampions.Select(kvp => new ChampionGroup
            {
                Header = kvp.Key,
                Children = kvp.Value
            })
        );
    }
}
