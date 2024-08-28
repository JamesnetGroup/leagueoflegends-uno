using Microsoft.UI.Xaml.Data;
namespace Leagueoflegends.Support.Local.Converters;

public class PercentToBadgeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is int percent)
            {
                return percent >= 50
                    ? "ms-appx:///Leagueoflegends.Support/Images/badge_champion2.png"
                    : "ms-appx:///Leagueoflegends.Support/Images/badge_champion1.png";
            }
            return "ms-appx:///Leagueoflegends.Support/Images/badge_champion1.png"; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
