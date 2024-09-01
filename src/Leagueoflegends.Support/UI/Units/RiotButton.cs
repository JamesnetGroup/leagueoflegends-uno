
namespace Leagueoflegends.Support.UI.Units;

public class RiotButton : Button
{
    public RiotButton()
    {
        DefaultStyleKey = typeof(RiotButton);
    }
}

public class RiotScheduleListBox : ListBox
{
    public RiotScheduleListBox()
    {
        DefaultStyleKey = typeof(RiotScheduleListBox);
        SelectionChanged += RiotScheduleListBox_SelectionChanged;
    }

    private void RiotScheduleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        foreach (var item in e.RemovedItems)
        {
            if (ContainerFromItem(item) is ListBoxItem listBoxItem)
            {
                listBoxItem.IsSelected = false;
            }
        }

        foreach (var item in e.AddedItems)
        {
            if (ContainerFromItem(item) is ListBoxItem listBoxItem)
            {
                listBoxItem.IsSelected = true;
            }
        }
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotScheduleListBoxItem();
    }
}


public class RiotScheduleListBoxItem : ListBoxItem
{
    public RiotScheduleListBoxItem()
    {
        DefaultStyleKey = typeof(RiotScheduleListBoxItem);
    }
}
