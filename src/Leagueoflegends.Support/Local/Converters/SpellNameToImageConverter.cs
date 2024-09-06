using Microsoft.UI.Xaml.Data;

namespace Leagueoflegends.Support.Local.Converters;

public class SpellNameToImageConverter : IValueConverter
{
    private const string BaseImagePath = "ms-appx:///Leagueoflegends.Support/Images/";

    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is string spellName && !string.IsNullOrEmpty(spellName))
        {
            string formattedSpellName = spellName.ToLower();
            return $"{BaseImagePath}spell_{formattedSpellName}.png";
        }
        return $"{BaseImagePath}spell_default.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
