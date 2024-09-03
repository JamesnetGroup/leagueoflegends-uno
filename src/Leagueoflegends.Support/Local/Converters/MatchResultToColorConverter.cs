using Microsoft.UI;
using Microsoft.UI.Xaml.Data;

namespace Leagueoflegends.Support.Local.Converters;

public class MatchResultToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is string result)
        {
            switch (result.ToLower())
            {
                case "victory": return "#1BA83E";
                case "defeat": return "#D31A45";
            }
        }
        return new SolidColorBrush(Colors.Gray); // 기본 색상
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
