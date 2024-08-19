using Jamesnet.Core;

namespace Leagueoflegends.Main.Local.ViewModel;

public class MainContentViewModel : ViewModelBase, IViewLoadable
{
    private readonly IContainer _container;
    private readonly ILayerManager _layerManager;

    private string _currentMenu;

    public string CurrentMenu
    {
        get => _currentMenu; 
        set => SetProperty(ref _currentMenu, value);
    }

    public ICommand SelectMenuCommand { get; }

    public MainContentViewModel(IContainer container, ILayerManager layerManager)
    {
        _container = container;
        _layerManager = layerManager;

        SelectMenuCommand = new RelayCommand<string>(SelectMenuItem);
    }

    private void SelectMenuItem(string menuName)
    {
        CurrentMenu = menuName;
    }

    public void Loaded()
    {
        SelectMenuItem("HOME");
    }
}
