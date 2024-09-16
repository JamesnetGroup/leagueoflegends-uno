using Jamesnet.Core;
using Leagueoflegends.Support.Local.Services;

namespace Leagueoflegends.Main.Local.ViewModels;
public class OptionContentViewModel
{
    private readonly IMenuManager _menu;

    public ICommand CloseCommand { get; private init; }
    public OptionContentViewModel(IMenuManager menu)
    {
        _menu = menu;

        CloseCommand = new RelayCommand(Close);
    }

    private void Close()
    {
        _menu.CloseOverlay("OptionContent");
    }
}
