using Microsoft.UI.Xaml.Data;

namespace Leagueoflegends.Support.Local.Converters
{
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

            // 스펠 이름이 없거나 null인 경우 기본 이미지 반환
            return $"{BaseImagePath}spell_default.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
