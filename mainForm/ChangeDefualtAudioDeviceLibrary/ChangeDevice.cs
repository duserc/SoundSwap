using SoundDeviceObjectDeclareLibrary;
using AudioSwitcher.AudioApi.CoreAudio;

namespace ChangeDefualtAudioDeviceLibrary;

public class ChangeDevice
{
    public static void ChangeDefaultDevice(SoundDevice soundDevice)
    {
        var controller = new CoreAudioController();
        var devices = controller.GetDevices();
        var desiredDevice = devices.FirstOrDefault(device => device.FullName == soundDevice.AudioDevice);
        if (desiredDevice != null)
        {
            desiredDevice.SetAsDefault();
        }
    }
}