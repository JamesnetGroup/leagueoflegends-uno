using Jamesnet.Core;
using System.Collections.ObjectModel;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.ViewModels;

public class SkinsContentViewModel : ViewModelBase
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

    private ObservableCollection<SkinGroup> _champions;
    public ObservableCollection<SkinGroup> Champions
    {
        get => _champions;
        set => SetProperty(ref _champions, value);
    }

    private readonly ISkinsDataLoader _skinsDataLoader;
    private readonly IFilterSortOptionsDataLoader _optionsDataLoader;

    public SkinsContentViewModel(ISkinsDataLoader skinsDataLoader, IFilterSortOptionsDataLoader optionsDataLoader)
    {
        _skinsDataLoader = skinsDataLoader;
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
        var groupedChampions = _skinsDataLoader.LoadSkinsGroupedByName();
        Champions = new ObservableCollection<SkinGroup>(
            groupedChampions
                .Select(kvp => new SkinGroup
                {
                    Header = $"{kvp.Key} Collection",
                    Children = kvp.Value.Where(skin => skin.IsPurchased).ToList()
                })
                .Where(group => group.Children.Any()) // Exclude empty groups
        );
    }

}
