using Microsoft.UI.Xaml.Data;

namespace Leagueoflegends.Support.Local.Converters;
public class DiscountRateConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is int discountRate)
        {
            return $"-{discountRate}%";
        }
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
