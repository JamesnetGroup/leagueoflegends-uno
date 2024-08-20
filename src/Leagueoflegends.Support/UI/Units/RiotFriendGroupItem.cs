using Jamesnet.Uno;

namespace Leagueoflegends.Support.UI.Units;

public class RiotFriendGroupItem : RecursiveItem
{
    public RiotFriendGroupItem()
    {
        DefaultStyleKey = typeof(RiotFriendGroupItem);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotFriendItemControl();
    }
}
