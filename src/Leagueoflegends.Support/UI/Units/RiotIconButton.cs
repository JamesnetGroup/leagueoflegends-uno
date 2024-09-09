using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.UI.Units;

public sealed class RiotIconButton : Button
{
    public static readonly DependencyProperty ControlTypeProperty = DependencyProperty.Register(nameof(IconType), typeof(SmallIconTyle), typeof(RiotIconButton), new PropertyMetadata(SmallIconTyle.Help, OnControlTypeChanged));

    public SmallIconTyle IconType
    {
        get => (SmallIconTyle)GetValue(ControlTypeProperty);
        set => SetValue(ControlTypeProperty, value);
    }

    public RiotIconButton()
    {
        this.DefaultStyleKey = typeof(RiotIconButton);
    }

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }

    private static void OnControlTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotIconButton button)
        {
            button.UpdateVisualState();
        }
    }

    private void UpdateVisualState()
    {
        VisualStateManager.GoToState(this, IconType.ToString(), false);
    }
}
