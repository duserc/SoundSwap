namespace mainForm;

using audioDeviceLibrary;
using System.Data;
using System.Windows.Forms;


public partial class mainForm : Form
{
    public mainForm()
    {
        InitializeComponent();
        PopulateAudioDeviceData();
    }

    private void PopulateAudioDeviceData()
    {

        DataTable audioDeviceTable = new DataTable();
        audioDeviceTable.Columns.Add("Audio Device", typeof(string));
        audioDeviceTable.Columns.Add("Active", typeof(bool));

        foreach (string audioDevice in audioDevices.EnumberateAudioDevices())
        {
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
}