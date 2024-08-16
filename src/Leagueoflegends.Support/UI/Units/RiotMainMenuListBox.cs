
namespace Leagueoflegends.Support.UI.Units;

public class RiotMainMenuListBox : ListBox
{
    public RiotMainMenuListBox()
    { 
        DefaultStyleKey = typeof(RiotMainMenuListBox);  
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotMainMenuListBoxItem();
    }
}
