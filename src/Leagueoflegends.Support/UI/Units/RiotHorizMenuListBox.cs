namespace Leagueoflegends.Support.UI.Units;

public class RiotHorizMenuListBox : ListBox
{
    public RiotHorizMenuListBox()
    { 
        DefaultStyleKey = typeof(RiotHorizMenuListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotHorizMenuListBoxItem();
    }
}
