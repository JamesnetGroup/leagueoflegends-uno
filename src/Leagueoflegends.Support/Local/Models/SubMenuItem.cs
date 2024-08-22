using Jamesnet.Core;

namespace Leagueoflegends.Support.Local.Models;

public class SubMenuItem : ViewModelBase
{
    private bool _isSelected;

    public int Seq { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }

    public bool IsSelected
    {
        get => _isSelected;
        set=> SetProperty(ref _isSelected, value);
    }
}
