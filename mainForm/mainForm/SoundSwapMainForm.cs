namespace mainForm;

using SoundDeviceObjectDeclareLibrary;
using audioDeviceLibrary;
using System.Data;
using System.Windows.Forms;
using CreateAudioDeviceList;
using NAudio.Wave;
using WK.Libraries.HotkeyListenerNS;
using static audioDeviceLibrary.audioDevices;

//using WK.Libraries.HotkeyListenerNS;

public partial class mainForm : Form
{
    private List<SoundDevice> listOfSoundDevices;

    public mainForm()
    {
        InitializeComponent();
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
            //newSoundDevices.Add(soundDevice);
            ////NEED TO WRITE CODE TO READ ACTIVE AND KEYBIND STATE HERE
            //DataRow newRow = audioDeviceTable.NewRow();
            //newRow["Audio Device"] = audioDevice;
            //newRow["Active"] = false;
            //audioDeviceTable.Rows.Add(newRow);
        }
        myDataGridView.RowHeadersVisible = false;
        myDataGridView.DataSource = audioDeviceTable;

        DataGridViewButtonColumn hotkeyColumn = new DataGridViewButtonColumn();
        hotkeyColumn.Name = "customHotkey";
        hotkeyColumn.HeaderText = "Custom Hotkey";
        hotkeyColumn.Text = "Unbound";
        hotkeyColumn.UseColumnTextForButtonValue = true;
        myDataGridView.Columns.Add(hotkeyColumn);
        myDataGridView.Columns["customHotkey"].DisplayIndex = audioDeviceTable.Columns.Count;
        myDataGridView.Columns["Audio Device"].SortMode = DataGridViewColumnSortMode.NotSortable;
        myDataGridView.Columns["Audio Device"].Resizable = DataGridViewTriState.False;
        myDataGridView.Columns["Audio Device"].ReadOnly = true;
        myDataGridView.Columns["Audio Device"].Frozen = true;
        myDataGridView.AllowUserToResizeColumns = false;
        myDataGridView.AllowUserToResizeRows = false;
        myDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

    }

    private void InitializeComponent()
    {

    }

    private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // if button clicked
        if (e.ColumnIndex == myDataGridView.Columns["customHotkey"].Index &&
            e.RowIndex >= 0 && e.RowIndex < myDataGridView.Rows.Count)
        {
            // access hotkey library, binding new hotkey


            // just create new form to recieve hotkey inputs

            SoundDevice soundDevice = newSoundDevices[e.RowIndex];
            //soundDevice.HotKey = hotKeyHandler.CreateBind();
            MessageBox.Show("You entered: " + e.ColumnIndex);
            HotKeyForm frm = new HotKeyForm();
            frm.Show();

            //string input = ShowInputDialog("Choose hotkey:", "Input Box");


        }
    }

}