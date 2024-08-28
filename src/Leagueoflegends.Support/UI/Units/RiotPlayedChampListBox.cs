

namespace Leagueoflegends.Support.UI.Units;
public class RiotPlayedChampListBox : ListBox
{
    public RiotPlayedChampListBox()
    {
        DefaultStyleKey = typeof(RiotPlayedChampListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotPlayedChampListBoxItem();
    }
}

public class RiotPlayedChampListBoxItem : ListBoxItem
{
    public RiotPlayedChampListBoxItem()
    {
        DefaultStyleKey = typeof(RiotPlayedChampListBoxItem);
    }
}
