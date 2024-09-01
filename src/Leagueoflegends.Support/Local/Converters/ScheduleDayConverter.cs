using Microsoft.UI.Xaml.Data;
namespace Leagueoflegends.Support.Local.Converters;

public class ScheduleDayConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is int day)
        {
            return $"DAY {day}";
        }
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
