namespace mainForm;

using SoundDeviceObjectDeclareLibrary;
using audioDeviceLibrary;
using System.Data;
using System.Windows.Forms;
using CreateAudioDeviceList;
using NAudio.Wave;
using WK.Libraries.HotkeyListenerNS;
using static audioDeviceLibrary.audioDevices;


public partial class mainForm : Form
{
    private List<SoundDevice> listOfSoundDevices;

    public mainForm()
    {
        //InitializeComponent();
        listOfSoundDevices = new List<SoundDevice>();
        PopulateAudioDeviceData();
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
            //Looping over every sound device in new list with updated settings
            foreach (SoundDevice SoundDevice in listOfSoundDevices)
            {
                //if the current sound device is not in new list, it means its probably first launch or new audio device
                if (!listOfSoundDevices.Contains(SoundDevice))
                {
                    //creating new sound device with defualt properties and adding it to the list of sound devices.
                    SoundDevice newSoundDev = new SoundDevice(SoundDevice.AudioDevice, false, audioDevice.IsDefaultDevice, null);
                    listOfSoundDevices.Add(newSoundDev);
                }
            }
        }
    }
}