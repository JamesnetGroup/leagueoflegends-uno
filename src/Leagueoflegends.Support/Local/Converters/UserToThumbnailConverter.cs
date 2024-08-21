using Microsoft.UI.Xaml.Data;

namespace Leagueoflegends.Support.Local.Converters;
internal class UserToThumbnailConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        return $"ms-appx:///Leagueoflegends.Support/Images/thumb-{value}.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
