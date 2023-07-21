namespace audioDeviceLibrary;

using NAudio.CoreAudioApi;

public class audioDevices
{
    public class AudioDeviceInfo
    {
        public string Name { get; set; }
        public bool IsDefaultDevice { get; set; }
        public float? DeviceVolume { get; set; }
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
                IsDefaultDevice = device.State == DeviceState.Active && device.ID == defaultDevice.ID,
                DeviceVolume = device.AudioEndpointVolume.MasterVolumeLevel
            };
            audioDevices.Add(deviceInfo);
        }
        return audioDevices;
    }
}