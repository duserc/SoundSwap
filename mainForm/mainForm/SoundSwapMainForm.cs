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

        foreach (string audioDevice in audioDevices.EnumberateAudioDevices())
        {
            DataRow newRow = audioDeviceTable.NewRow();
            newRow["Audio Device"] = audioDevice;
            audioDeviceTable.Rows.Add(newRow);
        }
        myDataGridView.DataSource = audioDeviceTable;

    }
}