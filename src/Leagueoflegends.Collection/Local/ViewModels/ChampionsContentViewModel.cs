using Jamesnet.Core;
using System.Collections.ObjectModel;
using Leagueoflegends.Collection.Local.Datas;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;  // ChampionStats가 정의된 네임스페이스를 포함

namespace Leagueoflegends.Collection.Local.ViewModels;

public class FilterOption
{
    public string Name { get; set; }
    public bool IsSelected { get; set; }
}

public class ChampionGroup
{
    public string Header { get; set; }
    public List<ChampionStats> Children { get; set; }
}

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

    private readonly IPersonalChampStatsDataLoader _dataLoader;

    public ChampionsContentViewModel(IPersonalChampStatsDataLoader dataLoader)
    {
        _dataLoader = dataLoader;
        InitializeViewModel();
    }

    private void InitializeViewModel()
    {
        Proficiency = 282;
        Achieve = 343;

        InitializeFilterOptions();
        InitializeSortOptions();
        LoadChampions();
    }

    private void InitializeFilterOptions()
    {
        FilterOptions = new ObservableCollection<FilterOption>
        {
            new FilterOption { Name = "All Champions", IsSelected = true },
            new FilterOption { Name = "Most Popular Position", IsSelected = false },
            new FilterOption { Name = "Role Group", IsSelected = false },
            new FilterOption { Name = "Ownership Status", IsSelected = false }
        };
        SelectedFilterOption = FilterOptions[0];
    }

    private void InitializeSortOptions()
    {
        SortOptions = new ObservableCollection<FilterOption>
        {
            new FilterOption { Name = "Alphabetical Order", IsSelected = true },
            new FilterOption { Name = "Champion Mastery", IsSelected = false },
            new FilterOption { Name = "Achievements Completed", IsSelected = false },
            new FilterOption { Name = "Chest Available", IsSelected = false }
        };
        SelectedSortOption = SortOptions[0];
    }

    private void LoadChampions()
    {
        var allChampions = _dataLoader.LoadChampionStats();

        Champions = new ObservableCollection<ChampionGroup>
        {
            new ChampionGroup
            {
                Header = "All Champions",
                Children = allChampions
            }
        };
    }
}
