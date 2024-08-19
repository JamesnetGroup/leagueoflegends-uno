using Jamesnet.Uno;

namespace Leagueoflegends.Support.UI.Units;

public class RiotFriendsTreeView : RecursiveControl
{
    public RiotFriendsTreeView()
    {
        DefaultStyleKey = typeof(RiotFriendsTreeView);
    }

    protected override RecursiveControlItem GetContainerForItem()
    {
        return new RiotFriendsTreeViewItem();
    }
}
