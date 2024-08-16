namespace Leagueoflegends.Support.UI.Units;

public class RiotMainIconMenuListBoxItem : RadioButton
{
    public string MenuIcon
    {
        get { return (string)GetValue(MenuIconProperty); }
        set { SetValue(MenuIconProperty, value); }
    }

    public static readonly DependencyProperty MenuIconProperty = DependencyProperty.Register("MenuIcon", typeof(string), typeof(RiotMainIconMenuListBoxItem), new PropertyMetadata(null));

    public RiotMainIconMenuListBoxItem()
    { 
        DefaultStyleKey = typeof(RiotMainIconMenuListBoxItem);
    }
}
    
