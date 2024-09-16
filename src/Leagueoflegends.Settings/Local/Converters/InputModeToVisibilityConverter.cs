using Leagueoflegends.Collection.Local.ViewModels;
using Microsoft.UI.Xaml.Data;

namespace Leagueoflegends.Settings.Local.Converters;

public class InputModeToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is InputMode selectedMode && parameter is string targetModeString)
        {
            if (Enum.TryParse(typeof(InputMode), targetModeString, out var targetMode))
            {
                return selectedMode.Equals(targetMode) ? Visibility.Visible : Visibility.Collapsed;
            }
        }
        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
