using SoundDeviceObjectDeclareLibrary;
using JsonDeseralizerLibrary;

namespace CreateAudioDeviceList;
public class ListManager
{
    public static List<SoundDevice> ListDatabase = new List<SoundDevice>();
    public static void CreateListFromJson()
    {
        ListDatabase.Clear();
        var devices = Program.ReadJsonSoundDeviceObject();
        if (devices != null)
        {
            for (int i = 0; i < devices.Count; i++)
            {
                ListDatabase.Add(devices[i]);
            }
        }
    }
}
