using Windows.Devices.Enumeration;

namespace Leagueoflegends.Settings.Local.Services;

public class UnoMicrophoneManager
{
    public async Task<List<DeviceInformation>> GetMicrophoneListAsync()
    {
        var devices = await DeviceInformation.FindAllAsync(DeviceClass.AudioCapture);
        return new List<DeviceInformation>(devices);
    }
}
