using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml.Controls.Primitives;

namespace Leagueoflegends.Support.UI.Units;
class RiotFoldableIcon : ToggleButton
{
    public RiotFoldableIcon()
    {
        DefaultStyleKey = typeof(RiotFoldableIcon);

        Tapped += RiotFoldableIcon_Tapped;
        DoubleTapped += RiotFoldableIcon_DoubleTapped;
    }

    private void RiotFoldableIcon_Tapped(object sender, Microsoft.UI.Xaml.Input.TappedRoutedEventArgs e)
    {
        e.Handled = true;
    }

    private void RiotFoldableIcon_DoubleTapped(object sender, Microsoft.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
    {
        e.Handled = true;
    }
}
