namespace audioDeviceLibrary;

using NAudio.CoreAudioApi;
using System.Xml.Linq;

public class audioDevices
{
    public class AudioDeviceInfo
    {
        public string Name { get; set; }
        public bool IsDefaultDevice { get; set; }
    }
    public static List<AudioDeviceInfo> EnumberateAudioDevices()
    {
        MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
        MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
        MMDevice defaultDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        var audioDevices = new List<AudioDeviceInfo>();

        foreach (MMDevice device in devices)
        {
            AudioDeviceInfo deviceInfo = new AudioDeviceInfo
            {
                Name = device.FriendlyName,
                IsDefaultDevice = device.State == DeviceState.Active && device.ID == defaultDevice.ID
            };

            audioDevices.Add(deviceInfo);
        }

        return audioDevices;
    }
}