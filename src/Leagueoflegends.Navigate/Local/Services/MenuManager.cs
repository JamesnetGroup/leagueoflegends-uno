using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using Leagueoflegends.Support.Local.Services;

namespace Leagueoflegends.Navigate.Local.Services;
public class MenuManager : IMenuManager
{
    private readonly IMenuDataLoader _dataLoader;
    private readonly ILayerManager _layerManager;
    private readonly IContainer _container;
    private List<MenuModel> _allMenuItems;
    private string _currentMainMenu;

    public event Action<List<MenuModel>> NavigationChanged;

    public MenuManager(IMenuDataLoader dataLoader, ILayerManager layerManager, IContainer container)
    {
        _dataLoader = dataLoader;
        _layerManager = layerManager;
        _container = container;
        _allMenuItems = _dataLoader.LoadMenuItems();
    }

    public List<MenuModel> GetMenus(string mainMenu)
    {
        return _allMenuItems
            .Where(item => item.Category == mainMenu)
            .GroupBy(item => item.Name)
            .Select(group => group.First())
            .OrderBy(item => item.Seq)
            .ToList();
    }

    public void Settings(string contentName)
    {
        contentName = $"{contentName}Content";

        _container.TryResolve<IView>(contentName, out var view);
        _layerManager.Show("SettingsLayer", view);
    }

    public void Navigate(string mainMenu)
    {
        _currentMainMenu = mainMenu;
        var subMenuItems = GetMenus(mainMenu);
        NavigationChanged?.Invoke(subMenuItems);
    }

    public void Navigate(MenuModel subMenuItem)
    {
        if (subMenuItem != null)
        {
            NavigateToSubMenu(subMenuItem);
        }
        else
        {
            NavigateToMainMenu();
        }
    }

    private void NavigateToMainMenu()
    {
        string category = _currentMainMenu.ToPascal();
        string contentName = $"{category}Content";

        _container.TryResolve<IView>(contentName, out var view);
        _layerManager.Show("ContentLayer", view);
    }

    private void NavigateToSubMenu(MenuModel subMenuItem)
    {
        string category = subMenuItem.Category.ToPascal();
        string menuName = subMenuItem.Name.ToPascal();
        string contentName = $"{category}{menuName}Content";

        _container.TryResolve<IView>(contentName, out var view);
        _layerManager.Show("ContentLayer", view);
    }

    public void Open(string contentName)
    {
        _container.TryResolve<IView>(contentName, out var view);
        _layerManager.Show("OverlayLayer", view);
    }

    public void Close(string contentName)
    {
        _layerManager.Hide("OverlayLayer");
    }
}
