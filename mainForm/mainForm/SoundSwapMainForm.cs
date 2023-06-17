using Microsoft.VisualBasic.Devices;

namespace MainForm;

using SoundDeviceObjectDeclareLibrary;
using audioDeviceLibrary;
using System.Data;
using System.Windows.Forms;
using CreateAudioDeviceList;
using NAudio.Wave;
using WK.Libraries.HotkeyListenerNS;
using static audioDeviceLibrary.audioDevices;
using MainForm;
using System;
using NAudio.CoreAudioApi;

public partial class SoundSwapMainForm : Form
{
    private List<SoundDevice> listOfSoundDevices;

    public SoundSwapMainForm()
    {
        //ListManager.CreateListFromJson(); //returns null
        listOfSoundDevices = new List<SoundDevice>();
        PopulateAudioDeviceData();
        InitializeComponent();
        PopulateDataGridView();
    }

    private void PopulateAudioDeviceData()
    {
        //getting the name of each audio device plugged into PC
        foreach (AudioDeviceInfo audioDevice in EnumberateAudioDevices())
        {
            //Looping over the SoundDevices inside the Settings.json
            foreach (SoundDevice SoundDevice in ListManager.ListDatabase)
            {
                //Checking if the sound device has already got settings saved
                if (SoundDevice.AudioDevice == audioDevice.Name)
                {
                    //if so:
                    listOfSoundDevices.Add(SoundDevice);
                }
            }
            // if sound device does not have settings saved, thus brand new deivce, adds to list
            if (!listOfSoundDevices.Any(x => x.AudioDevice == audioDevice.Name))
            {
                SoundDevice newSoundDev = new SoundDevice(audioDevice.Name, false, audioDevice.IsDefaultDevice, null);
                listOfSoundDevices.Add(newSoundDev);
            }
        }
    }
    private void PopulateDataGridView()
    {
        // better way to implement this?
        int i = 0;
        foreach (SoundDevice soundDevice in listOfSoundDevices)
        {
            //kind of WIP, don't like how DRY it is
            if (soundDevice.Hotkey == null)
            {
                AudioDeviceGridView.Rows.Insert(i, (soundDevice.AudioDevice), (soundDevice.IsActive), (soundDevice.IsPlaying), ("Unbound"));
            }
            else
            {
                AudioDeviceGridView.Rows.Insert(i, (soundDevice.AudioDevice), (soundDevice.IsActive), (soundDevice.IsPlaying), (soundDevice.Hotkey));
            }
            // better way to implement this?
            i++;
        }
    }
}