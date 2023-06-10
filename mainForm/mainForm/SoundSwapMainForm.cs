namespace mainForm;

using SoundDeviceLibrary;
using audioDeviceLibrary;
using AssignHotkeyForm;
using System.Data;
using System.Windows.Forms;
//using WK.Libraries.HotkeyListenerNS;

public partial class mainForm : Form
{
    private List<SoundDevice> newSoundDevices;

    public mainForm()
    {
        InitializeComponent();
        newSoundDevices = new List<SoundDevice>();
        PopulateAudioDeviceData();
    }

    private void PopulateAudioDeviceData()
    {
        myDataGridView.CellContentClick += DataGridView_CellContentClick;
        DataTable audioDeviceTable = new DataTable();
        audioDeviceTable.Columns.Add("Audio Device", typeof(string));
        audioDeviceTable.Columns.Add("Active", typeof(bool));

        foreach (string audioDevice in audioDevices.EnumberateAudioDevices())
        {
            SoundDevice soundDevice = new SoundDevice()
            {
                Name = audioDevice,
                IsActive = false,
                HotKey = "",
            };
            newSoundDevices.Add(soundDevice);
            //NEED TO WRITE CODE TO READ ACTIVE AND KEYBIND STATE HERE
            DataRow newRow = audioDeviceTable.NewRow();
            newRow["Audio Device"] = audioDevice;
            newRow["Active"] = false;
            audioDeviceTable.Rows.Add(newRow);
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