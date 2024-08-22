using Jamesnet.Core;
using Leagueoflegends.Support.Local.Models;
using Leagueoflegends.Support.Local.Services;

namespace Leagueoflegends.Navigate.Local.ViewModels;

public class SubMenuContentViewModel : ViewModelBase
{
    private readonly ISubMenuNavigator _subNavigator;
    private List<SubMenuItem> _subMenuItems;
    private SubMenuItem _selectedItem;

    public List<SubMenuItem> SubMenuItems
    {
        get => _subMenuItems;
        set => SetProperty(ref _subMenuItems, value);
    }

    public SubMenuItem SelectedItem
    {
        get => _selectedItem;
        set => SetProperty(ref _selectedItem, value, OnSelectedItemChanged);
    }

    private void OnSelectedItemChanged()
    {
    }

    public SubMenuContentViewModel(ISubMenuNavigator subNavigator)
    {
        _subNavigator = subNavigator;
        _subNavigator.SubMenuItemsUpdated += OnSubMenuItemsUpdated;
    }

    private void OnSubMenuItemsUpdated(List<SubMenuItem> subMenuItems)
    {
        SubMenuItems = subMenuItems;
        SelectedItem = subMenuItems.FirstOrDefault();
    }
}
