namespace JsonDeseralizerLibrary;

using SoundDeviceObjectDeclareLibrary;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;


[Serializable]
public class Program
{

    public static List<SoundDevice> ReadJsonSoundDeviceObject()
    {
        var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        string fileName = $"{path}\\config\\Settings.json";
        if (File.Exists(fileName))
        {
            var device =
                JsonConvert.DeserializeObject<List<SoundDevice>>
                    (File.ReadAllText(fileName));
            return device;
        }
        return null;

    }
}