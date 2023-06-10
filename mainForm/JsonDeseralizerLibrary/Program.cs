namespace JsonDeseralizerLibrary;

using SoundDeviceObjectDeclareLibrary;
using System;
using WK.Libraries.HotkeyListenerNS;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Globalization;
using System.Reflection;
using System.Diagnostics;

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