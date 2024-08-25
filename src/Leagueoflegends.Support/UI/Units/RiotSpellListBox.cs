
namespace Leagueoflegends.Support.UI.Units;

public class RiotSpellListBox : ListBox
{
    public RiotSpellListBox()
    {
        DefaultStyleKey = typeof(RiotSpellListBox);
        SelectionChanged += RiotSpellListBox_SelectionChanged;
    }

    private void RiotSpellListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        foreach (var item in e.RemovedItems)
        {
            if (ContainerFromItem(item) is RiotSpellListBoxItem listBoxItem)
            {
                listBoxItem.IsSelected = false;
            }
        }

        foreach (var item in e.AddedItems)
        {
            if (ContainerFromItem(item) is RiotSpellListBoxItem listBoxItem)
            {
                listBoxItem.IsSelected = true;
            }
        }
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotSpellListBoxItem();
    }
}
