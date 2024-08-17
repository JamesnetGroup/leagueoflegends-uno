using System.ComponentModel;
using System.Runtime.CompilerServices;
using Jamesnet.Core;

namespace Leagueoflegends.Main.Local.ViewModel;

public class MainContentViewModel : ViewModelBase, IViewLoadable
{
    private string _wallpaper;

    public string Wallpaper
    {
        get => _wallpaper; 
        set => SetProperty(ref _wallpaper, value);
    }
    
    public ICommand SelectMenuCommand { get; }

    public MainContentViewModel()
    {
        SelectMenuCommand = new RelayCommand<string>(SelectMenuItem);
    }

    private void SelectMenuItem(string menuName)
    {
        string fileName = "wallpaper-rucian.png";
        switch (menuName)
        {
            case "HOME": fileName = "wallpaper-rucian.png"; break;
            case "TFT": fileName = "wallpaper-singed.png"; break;
            case "CLASH": fileName = "wallpaper-sena.png"; break;
            case "PROFILE": fileName = "wallpaper-leona.jpg"; break;
            case "COLLECTION": fileName = "wallpaper-ezreal.jpg"; break;
            case "LOOT": fileName = "wallpaper-caitlyn.jpg"; break;
            case "SHOP": fileName = "wallpaper-gnar.jpg"; break;
            case "STORE": fileName = "wallpaper-maokai.jpg"; break;
        }
        Wallpaper = $"ms-appx:///Leagueoflegends.Support/Images/{fileName}";
    }

    public void Loaded()
    {
        SelectMenuItem("HOME");
    }
}
