using Jamesnet.Uno;

namespace Leagueoflegends.Support.UI.Units;

public class RiotFriendsTreeView : ListBox
{
    public RiotFriendsTreeView()
    {
        DefaultStyleKey = typeof(RiotFriendsTreeView);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotFriendsTreeViewItem();
    }
}
