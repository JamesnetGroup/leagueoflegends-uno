using Microsoft.UI.Xaml.Data;

namespace Leagueoflegends.Support.Local.Converters;

public class ChampionNameToThumbnailConverter : IValueConverter
{
    private const string BaseImagePath = "ms-appx:///Leagueoflegends.Support/Images/thumbnails/";

    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is string itemName && !string.IsNullOrEmpty(itemName))
        {
            return $"{BaseImagePath}{itemName}.png";
        }
        return $"{BaseImagePath}rocketbelt.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
