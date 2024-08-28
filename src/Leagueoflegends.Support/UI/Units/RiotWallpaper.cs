namespace Leagueoflegends.Support.UI.Units;

public class RiotWallpaper : Control
{
    public static readonly DependencyProperty MenuNameProperty = DependencyProperty.Register(
        "MenuName",
        typeof(string),
        typeof(RiotWallpaper),
        new PropertyMetadata(null, OnMenuNameChanged));

    public string MenuName
    {
        get { return (string)GetValue(MenuNameProperty); }
        set { SetValue(MenuNameProperty, value); }
    }

    public RiotWallpaper()
    {
        DefaultStyleKey = typeof(RiotWallpaper);
    }

    private static void OnMenuNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotWallpaper wallpaper)
        {
            wallpaper.UpdateVisualState();
        }
    }

    private void UpdateVisualState()
    {
        if (MenuName == "COLLECTION")
        {
            VisualStateManager.GoToState(this, "DarknessState", false);
        }
        else if (MenuName == "SHOP")
        {
            VisualStateManager.GoToState(this, "DarknessState", false);
        }
        else if (MenuName == "PROFILE")
        {
            VisualStateManager.GoToState(this, "DarknessState", false);
        }
        else
        {
            VisualStateManager.GoToState(this, "DefaultState", false);
        }
    }

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }
}
