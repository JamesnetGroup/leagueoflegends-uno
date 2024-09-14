using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.ViewModels;

public class GeneralContentViewModel : ViewModelBase, IViewLoadable
{
    private readonly IFilterDataLoader _filterData;
    private FilterOption _currentWindowSize;
    private List<FilterOption> _windowSizes;

    public FilterOption CurrentWindowSize
    {
        get => _currentWindowSize;
        set => SetProperty(ref _currentWindowSize, value);
    }

    public List<FilterOption> WindowSizes
    { 
        get => _windowSizes;
        set => SetProperty(ref _windowSizes, value);
    }

    public GeneralContentViewModel(IFilterDataLoader filterData)
    {
        _filterData = filterData;
    }

    public void Loaded()
    {
        WindowSizes = _filterData.GetByCategory("WindowSize");
        CurrentWindowSize= WindowSizes.FirstOrDefault();
    }
}
