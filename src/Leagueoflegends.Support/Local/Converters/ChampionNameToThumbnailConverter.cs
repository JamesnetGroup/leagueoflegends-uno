using System;
using System.Collections.Generic;
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

        // 아이템 이름이 없거나 null인 경우 기본 이미지 반환
        return $"{BaseImagePath}rocketbelt.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
