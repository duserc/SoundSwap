namespace SoundDeviceObjectDeclareLibrary;

using System.Reflection;
using WK.Libraries.HotkeyListenerNS;


public class SoundDevice
{
    public string? AudioDevice { get; set; }
    public bool IsActive { get; set; }
    public bool IsPlaying { get; set; }
    public string? Hotkey { get; set; }
    public SoundDevice(string? audioDevice, bool isActive, bool isPlaying, string? hotkey)
    {
        AudioDevice = audioDevice;
        IsActive = isActive;
        IsPlaying = isPlaying;
        Hotkey = hotkey;
    }
}
