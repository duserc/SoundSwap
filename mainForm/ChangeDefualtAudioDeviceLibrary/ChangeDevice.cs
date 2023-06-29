using SoundDeviceObjectDeclareLibrary;
using NAudio.CoreAudioApi;
using AudioSwitcher.AudioApi.CoreAudio;

namespace ChangeDefualtAudioDeviceLibrary;


public class ChangeDevice
{
    public static void ChangeDefaultDevice(SoundDevice soundDevice) //sound device is the device that had the hotkeypressed
    {
        var controller = new CoreAudioController();
        var devices = controller.GetDevices();
        var desiredDevice = devices.FirstOrDefault(device => device.FullName == soundDevice.AudioDevice);
        desiredDevice.SetAsDefault();
    }
}