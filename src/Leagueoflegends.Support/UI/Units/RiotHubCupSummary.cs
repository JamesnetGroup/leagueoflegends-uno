using Microsoft.UI.Xaml.Automation;
using Microsoft.UI.Xaml.Controls.Primitives;

namespace Leagueoflegends.Support.UI.Units;

public class RiotHubCupSummary : Control
{
    public RiotHubCupSummary()
    {
        DefaultStyleKey = typeof(RiotHubCupSummary);
    }
}

public class RiotTicketButton : Button
{
    public RiotTicketButton()
    {
        DefaultStyleKey = typeof(RiotTicketButton);
    }
}

public class RiotSwitchButton : CheckBox
{
    public RiotSwitchButton()
    {
        DefaultStyleKey = typeof(RiotSwitchButton);
    }
}

public class RiotTicketAddButton : Button
{
    public RiotTicketAddButton()
    {
        DefaultStyleKey = typeof(RiotTicketAddButton);
    }
}

public class RiotPositionButton : Button
{
    public static readonly DependencyProperty PositionProperty =
        DependencyProperty.Register(nameof(Position), typeof(string), typeof(RiotPositionButton),
            new PropertyMetadata(default(string), OnPositionChanged));

    public string Position
    {
        get { return (string)GetValue(PositionProperty); }
        set { SetValue(PositionProperty, value); }
    }

    public RiotPositionButton()
    {
        DefaultStyleKey = typeof(RiotPositionButton);
    }

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }

    private static void OnPositionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotPositionButton button)
        {
            button.UpdateVisualState();
        }
    }

    private void UpdateVisualState()
    {
        VisualStateManager.GoToState(this, Position, false);
    }
}
