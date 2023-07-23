using SoundDeviceObjectDeclareLibrary;
using AudioSwitcher.AudioApi.CoreAudio;
using AudioSwitcher.AudioApi;
using NAudio;
using NAudio.CoreAudioApi;
using System.Diagnostics;

namespace ChangeAudioVolumeLibrary
{
    public class Volume
    {
        private static readonly CoreAudioController audioController = new CoreAudioController();
        private static readonly IDevice[] devices = audioController.GetDevices().ToArray();

        private static MMDeviceEnumerator enumer = new MMDeviceEnumerator();
        public  static MMDevice dev = enumer.GetDefaultAudioEndpoint(DataFlow.Render, NAudio.CoreAudioApi.Role.Multimedia);

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
