using Leagueoflegends.Support.Local.Models;
using Microsoft.UI.Xaml.Data;

namespace Leagueoflegends.Clash.Local.Converters;

public class ShowMenuConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        return value is MenuModel menu && menu.Name.Equals(parameter);
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
