namespace CreateAudioDeviceList;
    
using SoundDeviceObjectDeclareLibrary;
using JsonDeseralizerLibrary;

//public static List<SoundDevice> ListDatabase = new List<SoundDevice>();

public class ListManager
{
    public static List<SoundDevice> ListDatabase = new List<SoundDevice>();

    public static void CreateListFromJson()
    {
        var devices = Program.ReadJsonSoundDeviceObject();
        for (int i = 0; i < devices.Count; i++)
        {
            ListDatabase.Add(devices[i]);
        }
    }
}
