namespace Leagueoflegends.Support.UI.Units;

public class RiotTextBoxCloseButton : Button
{
    public RiotTextBoxCloseButton()
    {
        this.DefaultStyleKey = typeof(RiotTextBoxCloseButton);
        Click += RiotTextBoxCloseButton_Click;
    }

    private void RiotTextBoxCloseButton_Click(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }
}
