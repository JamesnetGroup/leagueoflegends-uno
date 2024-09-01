using System.Globalization;
using Microsoft.UI.Xaml.Data;
namespace Leagueoflegends.Support.Local.Converters;

public class ScheduleDateConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is DateTime dateTime)
        {
            return dateTime.ToString("MMMM d ◇ h:mm tt - ", new CultureInfo("en-US")).ToUpper() +
                   dateTime.AddHours(2).ToString("h:mm tt", new CultureInfo("en-US")).ToUpper();
        }
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
