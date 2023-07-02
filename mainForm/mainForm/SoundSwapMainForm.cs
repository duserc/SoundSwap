using CreateAudioDeviceList;
using SoundDeviceObjectDeclareLibrary;
using System.Reflection;
using System.Text.Json;
using WK.Libraries.HotkeyListenerNS;
using static audioDeviceLibrary.audioDevices;
using ChangeDefualtAudioDeviceLibrary;

namespace MainForm;
public partial class SoundSwapMainForm : Form
{
    private List<SoundDevice> listOfSoundDevices;
    public HotkeyListener hkl = new HotkeyListener();

    public SoundSwapMainForm()
    {
        listOfSoundDevices = new List<SoundDevice>();
        PopulateAudioDeviceData();
        InitializeComponent();
        PopulateDataGridView();
        AppendHotkeyListener();
        hkl.HotkeyPressed += Hkl_HotkeyPressed;
        SoundSwapIcon.ContextMenuStrip = SoundSwapContextMenuStrip;
    }
    private void PopulateAudioDeviceData()
    {
        listOfSoundDevices.Clear();
        ListManager.CreateListFromJson();
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
        AudioDeviceGridView.Rows.Clear();
        foreach (SoundDevice soundDevice in listOfSoundDevices)
        {
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
        statusStripProgress(0, "Save Start");
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
            statusStripProgress(50, "Hotkey Assigned");
            SoundDevice soundDevice = new SoundDevice(AudioDevice, enabledBool, currentlyPlayingBool, hotkeyString);
            WriteJsonList.Add(soundDevice);
            statusStripProgress(60, "Hotkey List Appeneded");
        }
        var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        string directoryPath = Path.Combine(path, "config");
        string fileName = Path.Combine(directoryPath, "Settings.json");
        if (!File.Exists(fileName))
        {
            Directory.CreateDirectory(directoryPath);
            using (File.Create(fileName))
            {
                statusStripProgress(70, "Settings.Json Created");
            }
        }
        if (File.Exists(fileName))
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = System.Text.Json.JsonSerializer.Serialize(WriteJsonList, options);
            File.WriteAllText(fileName, jsonString);
        }
        statusStripProgress(80, "Config Saved");
        listOfSoundDevices = WriteJsonList;
        AppendHotkeyListener();
        statusStripProgress(90, "Listening for correct hotkeys");
        statusStripProgress(100, "Save Complete");
    }
    private void Hkl_HotkeyPressed(object sender, HotkeyEventArgs e)
    {
        statusStripProgress(0, "Hotkey Pressed");
        var soundDevicesCopy = new List<SoundDevice>(listOfSoundDevices);
        float statusCount = 90 / soundDevicesCopy.Count;
        int deviceCounter = 0;
        string? ActivatedDevice = null;
        foreach (SoundDevice soundDevice in soundDevicesCopy)
        {
            if (e.Hotkey == soundDevice.Hotkey)
            {
                foreach (SoundDevice curDev in soundDevicesCopy)
                {
                    if (curDev.AudioDevice != soundDevice.AudioDevice)
                    {
                        curDev.IsPlaying = false;
                    }
                    else
                    {
                        if (soundDevice.IsActive == true)
                        {
                            soundDevice.IsPlaying = true;
                            ActivatedDevice = curDev.AudioDevice;
                            ChangeDevice.ChangeDefaultDevice(soundDevice);
                        }
                        else
                        {
                            soundDevice.IsPlaying = false;
                        }
                    }
                }
            }
            deviceCounter++;
            int progressCount = (int)(Math.Round(statusCount) * deviceCounter);
            if (progressCount < 100)
            {
                statusStripProgress((progressCount), $"Checking Device {deviceCounter} for matching hotkey");
            }
        }
        listOfSoundDevices = soundDevicesCopy;
        if (ActivatedDevice == null)
        {
            statusStripProgress(100, "Inactive Hotkey Registered");
        }
        else
        {
            statusStripProgress(100, $"Hotkey Registered: {ActivatedDevice}");
        }
        
        PopulateDataGridView();
    }
    private void AudioDeviceGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        DataGridView dataGridView = (DataGridView)sender;

        if (dataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn checkBoxColumn)
        {
            if (checkBoxColumn.Name == "currentlyPlayingBoolCollumn")
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        DataGridViewCheckBoxCell checkBoxCell = row.Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                        checkBoxCell.Value = false;
                    }
                }
            }
        }
    }
    private void AppendHotkeyListener()
    {
        hkl.RemoveAll();
        if (listOfSoundDevices.Count != 0)
        {
            for (int i = 0; i < listOfSoundDevices.Count; i++)
            {
                if (listOfSoundDevices[i].Hotkey is Hotkey)
                {
                    {
                        if (listOfSoundDevices[i].Hotkey.KeyCode != 0)
                        {
                            hkl.Add(listOfSoundDevices[i].Hotkey);
                        }

                    }
                }
            }
        }
    }
    private void SoundSwapIcon_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        Show();
        WindowState = FormWindowState.Normal;
    }

    private void SoundSwapMainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = true;
            Hide();
        }
        else
        {
            SoundSwapIcon.Dispose();
            Application.Exit();
        }
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show();
        WindowState = FormWindowState.Normal;
    }

    private void quitToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
    {
        SoundSwapIcon.Visible = false;
        SoundSwapIcon.Dispose();
        Application.Exit();
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (AudioDeviceGridView.CurrentCell != null)
        {
            AudioDeviceGridView.EndEdit();
        }
        saveButton_Click(sender, e);
    }

    private void toSystemTrayToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private void quitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SoundSwapIcon.Visible = false;
        SoundSwapIcon.Dispose();
        Application.Exit();
    }

    private void statusStripReset()
    {
        toolStripStatusLabel1.Text = "Ready";
        toolStripProgressBar1.Value = 0;
    }
    private async Task statusStripProgress(int progress, string? status)
    {
        if (progress == 0)
        {
            statusStripReset();
        }
        if (progress > 0 || progress < 100)
        {
            toolStripStatusLabel1.Text = $"{status}";
            toolStripProgressBar1.Value = progress;
        }
        if (progress == 100)
        {
            await Task.Delay(1000);
            statusStripReset();
        }
    }

    private void detectNewAudioDeviceToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Restart();
    }

    private void resetConfigToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Resetting the Config will remove all saved settings. Continue?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

        if (result == DialogResult.Yes)
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string directoryPath = Path.Combine(path, "config");
            string settingsFile = Path.Combine(directoryPath, "Settings.json");
            if (File.Exists(settingsFile))
            {
                File.Delete(settingsFile);
            }
            Application.Restart();
        }
    }
}