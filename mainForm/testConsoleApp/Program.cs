//using NAudio.CoreAudioApi;
//using NAudio.Wave;
//using System.Data;

//public class AudioDeviceManager
//{
//    public static void EnumerateAudioDevices()
//    {
//        MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
//        MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);

//        foreach (MMDevice device in devices)
//        {
//            Console.WriteLine("Device: " + device.FriendlyName);
//        }
//    }
//}