using SoundDeviceObjectDeclareLibrary;
using AudioSwitcher.AudioApi.CoreAudio;
using AudioSwitcher.AudioApi;

namespace ChangeAudioVolumeLibrary
{
    public class Volume
    {
        private static readonly CoreAudioController audioController = new CoreAudioController();
        private static readonly IDevice[] devices = audioController.GetDevices().ToArray();

        public static void ChangeDeviceVolume(SoundDevice soundDevice, float volume)
        {
            var desiredDevice = devices.FirstOrDefault(device => device.FullName == soundDevice.AudioDevice);
            if (desiredDevice != null)
            {
                desiredDevice.Volume = volume;
            }
        }
        public static object GetDeviceVolume(SoundDevice soundDevice)
        {
            var desiredDevice = devices.FirstOrDefault(device => device.FullName == soundDevice.AudioDevice);
            return desiredDevice.Volume;
        }
    }
}
