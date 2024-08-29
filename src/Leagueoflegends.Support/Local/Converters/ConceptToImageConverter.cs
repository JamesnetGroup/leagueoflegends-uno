using Microsoft.UI.Xaml.Data;
namespace Leagueoflegends.Support.Local.Converters;

public class ConceptToImageConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is string concept)
        {
            return $"ms-appx:///Leagueoflegends.Support/Images/Concepts/{concept}.png";
        }
        return "ms-appx:///Leagueoflegends.Support/Images/Concepts/warrior.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException("ConvertBack is not implemented for this one-way converter.");
    }
}
