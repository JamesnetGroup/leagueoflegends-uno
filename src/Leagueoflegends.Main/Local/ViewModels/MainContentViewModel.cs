using Jamesnet.Core;
using Jamesnet.Uno;
using Microsoft.UI.Xaml.Controls;

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

        if (menuName == "TFT")
        {
            IView tft = _container.Resolve<IView>("TftContent");
            _layerManager.AddView("ContentLayer", tft);
            _layerManager.ActivateView("ContentLayer", tft);
        }
        else if (menuName == "HOME")
        {
            IView home = _container.Resolve<IView>("HomeContent");
            _layerManager.AddView("ContentLayer", home);
            _layerManager.ActivateView("ContentLayer", home);
        }
    }

    public void Loaded()
    {
        SelectMenuItem("HOME");
    }
}
