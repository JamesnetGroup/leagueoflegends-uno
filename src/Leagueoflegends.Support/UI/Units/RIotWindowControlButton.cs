using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.UI.Units;

public sealed class RiotWindowControlButton : Button
{
    public static readonly DependencyProperty ControlTypeProperty = DependencyProperty.Register(nameof(IconType), typeof(SmallIconTyle), typeof(RiotWindowControlButton), new PropertyMetadata(SmallIconTyle.Help, OnControlTypeChanged));

    public SmallIconTyle IconType
    {
        get => (SmallIconTyle)GetValue(ControlTypeProperty);
        set => SetValue(ControlTypeProperty, value);
    }

    public RiotWindowControlButton()
    {
        this.DefaultStyleKey = typeof(RiotWindowControlButton);
    }

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }

    private static void OnControlTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotWindowControlButton button)
        {
            button.UpdateVisualState();
        }
    }

    private void UpdateVisualState()
    {
        VisualStateManager.GoToState(this, IconType.ToString(), false);
    }
}
