namespace MainForm;

using Microsoft.VisualBasic.Devices;
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
using System.Reflection;
using Newtonsoft.Json;
using static System.Windows.Forms.Design.AxImporter;
using System.Text.Json;

public partial class SoundSwapMainForm : Form
{
    private List<SoundDevice> listOfSoundDevices;
    private HotkeyListener hotkeyListener;

    public SoundSwapMainForm()
    {
        //ListManager.CreateListFromJson(); //returns null
        listOfSoundDevices = new List<SoundDevice>();
        ListManager.CreateListFromJson();
        PopulateAudioDeviceData();
        InitializeComponent();
        PopulateDataGridView();
        DataGridViewStyling();
        AudioDeviceGridView.EditingControlShowing += AudioDeviceGridView_EditingControlShowing;
        hotkeyListener = new HotkeyListener();
        var hkl = new HotkeyListener();
        hkl.HotkeyPressed += Hkl_HotkeyPressed;
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
        foreach (SoundDevice soundDevice in listOfSoundDevices)
        {
            //if (soundDevice.Hotkey == null)
            //{
            //    AudioDeviceGridView.Rows.Add((soundDevice.AudioDevice), (soundDevice.IsActive), (soundDevice.IsPlaying), ("Unbound"));
            //}
            AudioDeviceGridView.Rows.Add((soundDevice.AudioDevice), (soundDevice.IsActive), (soundDevice.IsPlaying), (soundDevice.Hotkey));
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

    public void saveButton_Click(object sender, EventArgs e)
    {
        List<SoundDevice> WriteJsonList = new List<SoundDevice>();
        foreach (DataGridViewRow dr in AudioDeviceGridView.Rows)
        {
            var AudioDevice = string.Empty;
            bool enabledBool = false;
            var currentlyPlayingBool = false;
            Hotkey? hotkeyString = null;
            foreach (DataGridViewCell dc in dr.Cells)
            {
                if (dc.OwningColumn == AudioDeviceColumn)
                {
                    AudioDevice = dc.Value as string;
                }
                if (dc.OwningColumn == enabledBoolColumn)
                {
                    enabledBool = (bool)dc.Value;
                }
                if (dc.OwningColumn == currentlyPlayingBoolCollumn)
                {
                    currentlyPlayingBool = (bool)dc.Value;
                }
                if (dc.OwningColumn == hotkeyStringColumn)
                {
                    if (dc.Value != null)
                    {
                        if (dc.Value is Hotkey)
                        {
                            hotkeyString = dc.Value as Hotkey;
                        }
                        else if (dc.Value is string hotkeyText)
                        {
                            hotkeyString = new Hotkey(hotkeyText);
                        }
                    }
                }
            }
            SoundDevice soundDevice = new SoundDevice(AudioDevice, enabledBool, currentlyPlayingBool, hotkeyString);
            WriteJsonList.Add(soundDevice);
        }
        var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        string fileName = $"{path}\\config\\Settings.json";
        if (File.Exists(fileName))
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = System.Text.Json.JsonSerializer.Serialize(WriteJsonList, options);
            File.WriteAllText(fileName, jsonString);
        }
        listOfSoundDevices = WriteJsonList;
    }
    private void Hkl_HotkeyPressed(object sender, HotkeyEventArgs e)
    {
        foreach (SoundDevice soundDevice in listOfSoundDevices)
        {
            if (e.Hotkey == soundDevice.Hotkey)
            {
                // SET ACTIVE AUDIO DEVICE TO HOTKEYDEVICE PRESSED
                // SET OTHER NON ACTIVES TO FALSE
                // POTENTIALLY USE IDS TO SAVE MEMORY
            }
        }

    }

    private void AudioDeviceGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        DataGridView dataGridView = (DataGridView)sender;

        if (dataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn checkBoxColumn)
        {
            if (checkBoxColumn.Name == "currentlyPlayingBoolCollumn")
            {
                // Clear all checkboxes in the column
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Index != e.RowIndex) // Skip the clicked row
                    {
                        DataGridViewCheckBoxCell checkBoxCell = row.Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                        checkBoxCell.Value = false;
                    }
                }
            }
        }
    }
}