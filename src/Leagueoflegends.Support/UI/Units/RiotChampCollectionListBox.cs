using Jamesnet.Uno;

namespace Leagueoflegends.Support.UI.Units;
public class RiotChampCollectionListBox : ListBox
{
    public RiotChampCollectionListBox()
    {
        DefaultStyleKey = typeof(RiotChampCollectionListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotChampCollectionGroupItem();
    }
}

public class RiotChampCollectionGroupItem : RecursiveControl
{
    public RiotChampCollectionGroupItem()
    {
        DefaultStyleKey = typeof(RiotChampCollectionGroupItem);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotChampCollectionItemControl();
    }
}

public class RiotChampCollectionItemControl : RadioButton
{
    public RiotChampCollectionItemControl()
    {
        DefaultStyleKey = typeof(RiotChampCollectionItemControl);
    }
}
