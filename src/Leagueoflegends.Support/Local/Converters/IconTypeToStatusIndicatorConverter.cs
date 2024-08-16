using Microsoft.UI.Xaml.Data;
namespace Leagueoflegends.Support.Local.Converters;

public class IconTypeToStatusIndicatorConverter : IValueConverter
{
    private const string RpPath = "ms-appx:///Leagueoflegends.Support/Images/rp.png";
    private const string BlueEssencePath = "ms-appx:///Leagueoflegends.Support/Images/blue-essence.png";

    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is string iconType)
        {
            return iconType.ToLower() switch
            {
                "rp" => RpPath,
                "blueessence" => BlueEssencePath,
                _ => string.Empty
            };
        }
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
