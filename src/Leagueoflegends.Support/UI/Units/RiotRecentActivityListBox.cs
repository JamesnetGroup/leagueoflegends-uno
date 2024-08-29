namespace Leagueoflegends.Support.UI.Units;

public class RiotRecentActivityListBox : ListBox
{
    public RiotRecentActivityListBox()
    {
        DefaultStyleKey = typeof(RiotRecentActivityListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotRecentActivityListBoxItem();
    }
}
