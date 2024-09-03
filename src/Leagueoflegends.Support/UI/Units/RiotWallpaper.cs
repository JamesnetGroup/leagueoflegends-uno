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
        switch (MenuName)
        {
            case "COLLECTION": VisualStateManager.GoToState(this, "DarknessState", false); break;
            case "SHOP": VisualStateManager.GoToState(this, "DarknessState", false); break;
            case "PROFILE": VisualStateManager.GoToState(this, "DarknessState", false); break;
            case "CLASH": VisualStateManager.GoToState(this, "Darkness2State", false); break;
            case "TFT": VisualStateManager.GoToState(this, "Darkness3State", false); break;
            default: VisualStateManager.GoToState(this, "DefaultState", false); break;
        }
    }

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }
}
