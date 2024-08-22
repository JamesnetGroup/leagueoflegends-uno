using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using Leagueoflegends.Support.Local.Services;

namespace Leagueoflegends.Navigate.Local.Services;

public class SubMenuNavigator : ISubMenuNavigator
{
    private readonly ISubMenuDataLoader _dataLoader;
    private List<SubMenuItem> _allMenuItems;

    public event Action<List<SubMenuItem>> SubMenuItemsUpdated;

    public SubMenuNavigator(ISubMenuDataLoader dataLoader)
    {
        _dataLoader = dataLoader;
        _allMenuItems = _dataLoader.LoadMenuItems();
    }

    public void UpdateSubMenuItems(string mainMenu)
    {
        var subMenuItems = GetSubMenuItems(mainMenu);
        SubMenuItemsUpdated?.Invoke(subMenuItems);
    }

    public List<SubMenuItem> GetSubMenuItems(string mainMenu)
    {
        return _allMenuItems
            .Where(item => item.Category == mainMenu)
            .GroupBy(item => item.Name)  // 이름으로 그룹화
            .Select(group => group.First())  // 각 그룹에서 첫 번째 항목만 선택
            .OrderBy(item => item.Seq)  // Seq로 정렬
            .ToList();
    }
}
