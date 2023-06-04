namespace audioDeviceLibrary;
using NAudio.CoreAudioApi;
using audioDeviceLibrary;

public class audioDevices
{
    public static List<string> EnumberateAudioDevices()
    {
        MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
        MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
        var audioDevices = new List<string>();

        foreach (MMDevice device in devices)
        {
            audioDevices.Add(device.FriendlyName);
        }

        return audioDevices;
    }
}