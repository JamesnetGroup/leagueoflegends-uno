using Jamesnet.Uno;

namespace Leagueoflegends.Support.UI.Units;

public class RiotChampSkinGroupItem : RecursiveControl
{
    public RiotChampSkinGroupItem()
    {
        DefaultStyleKey = typeof(RiotChampSkinGroupItem);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotChampSkinItemControl();
    }
}
