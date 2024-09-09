using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Services;

public interface IMenuManager
{
    event Action<List<MenuModel>> NavigationChanged;
    void Settings(string subMenuItem);
    void Navigate(string mainMenu);
    void Navigate(MenuModel subMenuItem);
    List<MenuModel> GetMenus(string mainMenu);
    void Open(string contentName);
    void Close(string contentName);
}
