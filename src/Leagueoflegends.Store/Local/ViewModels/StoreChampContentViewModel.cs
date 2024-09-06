using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using Leagueoflegends.Store.Local.Datas;

namespace Leagueoflegends.Collection.Local.ViewModels;

public class StoreChampContentViewModel : ViewModelBase
{
    private readonly IFilterDataLoader _filterData;
    private readonly IStoreChampDataLoader _storeChampData;
    private bool _isChampionsSelected;
    private bool _isEternalsSelected;
    private bool _isBundlesSelected;
    private FilterOption _currentChamp;
    private FilterOption _currentEternal;
    private FilterOption _currentBundle;

    public bool IsChampionsSelected
    {
        get => _isChampionsSelected;
        set => SetProperty(ref _isChampionsSelected, value);
    }

    public bool IsEternalsSelected
    {
        get => _isEternalsSelected;
        set => SetProperty(ref _isEternalsSelected, value);
    }

    public bool IsBundlesSelected
    {
        get => _isBundlesSelected;
        set => SetProperty(ref _isBundlesSelected, value);
    }

    public FilterOption CurrentChamp
    {
        get => _currentChamp;
        set => SetProperty(ref _currentChamp, value);
    }

    public FilterOption CurrentEternal
    {
        get => _currentEternal;
        set => SetProperty(ref _currentEternal, value);
    }

    public FilterOption CurrentBundle
    {
        get => _currentBundle;
        set => SetProperty(ref _currentBundle, value);
    }

    public List<FilterOption> ChampOptions { get; set; }
    public List<FilterOption> EternalOptions { get; set; }
    public List<FilterOption> BundleOptions { get; set; }
    public List<StoreChamp> Champions { get; set; }

    public StoreChampContentViewModel(IFilterDataLoader filterData, IStoreChampDataLoader storeChampData)
    {
        _filterData = filterData;
        _storeChampData = storeChampData;
        IsChampionsSelected = true;

        LoadFilters();
        LoadChamps();
    }

    private void LoadFilters()
    {
        ChampOptions = _filterData.GetByCategory("ItemSortOptions");
        EternalOptions = _filterData.GetByCategory("ItemSortOptions");
        BundleOptions = _filterData.GetByCategory("ItemSortOptions");

        CurrentChamp = ChampOptions.FirstOrDefault();
        CurrentEternal = EternalOptions.FirstOrDefault();
        CurrentBundle = BundleOptions.FirstOrDefault();
    }

    private void LoadChamps()
    {
        Champions = _storeChampData.LoadStoreChamps();
    }
}
