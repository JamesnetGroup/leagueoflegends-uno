
namespace Leagueoflegends.Support.UI.Units;
public class RiotComboBox : ComboBox
{
    public RiotComboBox()
    {
        DefaultStyleKey = typeof(RiotComboBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotComboBoxItem();
    }
}
