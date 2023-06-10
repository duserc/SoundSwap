namespace CreateAudioDeviceList;
    
using audioDeviceLibrary;
using SoundDeviceLibrary;
using JsonDeseralizerLibrary;

//public static List<SoundDevice> ListDatabase = new List<SoundDevice>();

public class ListManager
{
    static void Main(string[] args)
    {
        var devices = Program.ReadJsonSoundDeviceObject();
        for (int i = 0; i < devices.Count; i++)
        {
            
        }

    }


}
