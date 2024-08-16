using Microsoft.UI.Xaml.Data;
namespace Leagueoflegends.Support.Local.Converters;

public class BoolToPlayStopConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        return (bool)value ? "STOP" : "PLAY";
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
