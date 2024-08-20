using Jamesnet.Uno;
using Microsoft.UI.Xaml.Controls.Primitives;

namespace Leagueoflegends.Support.UI.Units;

public class RiotFriendsTreeViewItem : RecursiveItem
{
    public RiotFriendsTreeViewItem()
    {
        DefaultStyleKey = typeof(RiotFriendsTreeViewItem);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotFriendsUserTreeViewItem();
    }
}

public class RiotFriendsUserTreeViewItem : ContentControl
{
    public RiotFriendsUserTreeViewItem()
    {
        DefaultStyleKey = typeof(RiotFriendsUserTreeViewItem);
    }
}
