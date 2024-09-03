using Microsoft.UI.Xaml.Data;

namespace Leagueoflegends.Support.Local.Converters;

public class ItemNameToImageConverter : IValueConverter
{
    private const string BaseImagePath = "ms-appx:///Leagueoflegends.Support/Images/Items/";

    private static readonly Dictionary<string, string> ItemNameToFileNameMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "Luden's Tempest", "rocketbelt" },
        { "Sorcerer's Shoes", "ionianshoes" },
        { "Zhonya's Hourglass", "zhonya" },
        { "Rabadon's Deathcap", "rabadon" },
        { "Void Staff", "voidstaff" },
        { "Morellonomicon", "mortalreminder" },
        { "Farsight Alteration", "ward" },
        { "Locket of the Iron Solari", "solari" },
        { "Plated Steelcaps", "platedshoes" },
        { "Knight's Vow", "doranring" },
        { "Thornmail", "infinityedge" },
        { "Zeke's Convergence", "trinityforce" },
        { "Watchful Wardstone", "wardstone" },
        { "Oracle Lens", "oraclelens" },
        { "Immortal Shieldbow", "quicksilver" },
        { "Infinity Edge", "infinityedge" },
        { "Berserker's Greaves", "berserkersgreaves" },
        { "Bloodthirster", "galeforce" },
        { "Mortal Reminder", "mortalreminder" },
        { "Guardian Angel", "cloak" },
        { "Kraken Slayer", "trinityforce" },
        { "Runaan's Hurricane", "thecollector" },
        { "Last Whisper", "dominik" },
        { "Stealth Ward", "ward" }
    };

    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is string itemName && !string.IsNullOrEmpty(itemName))
        {
            if (ItemNameToFileNameMap.TryGetValue(itemName, out string fileName))
            {
                return $"{BaseImagePath}{fileName}.png";
            }
            // 매핑이 없는 경우 기본 이미지 반환
            return $"{BaseImagePath}rocketbelt.png";
        }

        // 아이템 이름이 없거나 null인 경우 기본 이미지 반환
        return $"{BaseImagePath}rocketbelt.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
