﻿using WK.Libraries.HotkeyListenerNS;

namespace SoundDeviceObjectDeclareLibrary;
public class SoundDevice
{
    public string? AudioDevice { get; set; }
    public bool IsActive { get; set; }
    public bool IsPlaying { get; set; }
    public Hotkey? Hotkey { get; set; }
    public float? DeviceVolume { get; set; }

    public SoundDevice(string? audioDevice, bool isActive, bool isPlaying, float? deviceVolume, Hotkey? hotkey)
    {
        AudioDevice = audioDevice;
        IsActive = isActive;
        IsPlaying = isPlaying;
        Hotkey = hotkey;
        DeviceVolume = deviceVolume;
    }
}
