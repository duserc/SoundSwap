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
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;

public partial class SoundSwapMainForm : Form
{
    private List<SoundDevice> listOfSoundDevices;
    private HotkeyListener hotkeyListener;

    public SoundSwapMainForm()
    {
        //ListManager.CreateListFromJson(); //returns null
        listOfSoundDevices = new List<SoundDevice>();
        PopulateAudioDeviceData();
        InitializeComponent();
        PopulateDataGridView();
        DataGridViewStyling();
        AudioDeviceGridView.EditingControlShowing += AudioDeviceGridView_EditingControlShowing;
        hotkeyListener = new HotkeyListener();
    }
    private void DataGridViewStyling()
    {
        //AudioDeviceGridView.RowHeadersVisible = false;
        //AudioDeviceGridView.AllowUserToAddRows = false;
        //AudioDeviceGridView.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        //AudioDeviceGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        //AudioDeviceGridView.Columns[2].Visible = false;
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
    private void AudioDeviceGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
        if (AudioDeviceGridView.CurrentCell.ColumnIndex == 3 && e.Control is System.Windows.Forms.TextBox)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)e.Control;
            var hks = new HotkeySelector();
            hks.Enable(textBox);
        }
    }
}