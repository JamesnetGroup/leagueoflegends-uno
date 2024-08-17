namespace Leagueoflegends.Support.UI.Units;

public class RiotMainMenuListBoxItem : RadioButton
{
    public string MenuName
    {
        get { return (string)GetValue(MenuNameProperty); }
        set { SetValue(MenuNameProperty, value); }
    }

    public string MenuIcon
    {
        get { return (string)GetValue(MenuIconProperty); }
        set { SetValue(MenuIconProperty, value); }
    }



    public bool IsLoadedFocus
    {
        get { return (bool)GetValue(IsLoadedFocusProperty); }
        set { SetValue(IsLoadedFocusProperty, value); }
    }

    // Using a DependencyProperty as the backing store for IsLoadedFocus.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty IsLoadedFocusProperty =
        DependencyProperty.Register("IsLoadedFocus", typeof(bool), typeof(RiotMainMenuListBoxItem), new PropertyMetadata(false));



    public static readonly DependencyProperty MenuNameProperty = DependencyProperty.Register("MenuName", typeof(string), typeof(RiotMainMenuListBoxItem), new PropertyMetadata(null));
    public static readonly DependencyProperty MenuIconProperty = DependencyProperty.Register("MenuIcon", typeof(string), typeof(RiotMainMenuListBoxItem), new PropertyMetadata(null));

    public RiotMainMenuListBoxItem()
    { 
        DefaultStyleKey = typeof(RiotMainMenuListBoxItem);

        Loaded += RiotMainMenuListBoxItem_Loaded;
    }

    private void RiotMainMenuListBoxItem_Loaded(object sender, RoutedEventArgs e)
    {
        if (IsLoadedFocus)
        {
            IsChecked = true;
        }
    }
}
    
