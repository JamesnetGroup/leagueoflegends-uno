
namespace Leagueoflegends.Support.UI.Units;

public class RiotMainIconMenuListBox : ListBox
{
    public RiotMainIconMenuListBox()
    { 
        DefaultStyleKey = typeof(RiotMainIconMenuListBox);  
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotMainIconMenuListBoxItem();
    }
}
