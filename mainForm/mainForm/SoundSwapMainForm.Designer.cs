namespace mainForm
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            audioDeviceTable = new DataGridView();
            audioDeviceCol = new DataGridViewTextBoxColumn();
            toggleHotkeyCol = new DataGridViewCheckBoxColumn();
            uniqueHotKeyButtonCol = new DataGridViewButtonColumn();
            audioDevicesBindingSource = new BindingSource(components);
            myDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)audioDeviceTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)audioDevicesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myDataGridView).BeginInit();
            SuspendLayout();
            // 
            // audioDeviceTable
            // 
            audioDeviceTable.AutoGenerateColumns = false;
            audioDeviceTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            audioDeviceTable.Columns.AddRange(new DataGridViewColumn[] { audioDeviceCol, toggleHotkeyCol, uniqueHotKeyButtonCol });
            audioDeviceTable.DataSource = audioDevicesBindingSource;
            audioDeviceTable.Location = new Point(12, 286);
            audioDeviceTable.Name = "audioDeviceTable";
            audioDeviceTable.RowTemplate.Height = 25;
            audioDeviceTable.Size = new Size(665, 149);
            audioDeviceTable.TabIndex = 0;
            // 
            // audioDeviceCol
            // 
            audioDeviceCol.HeaderText = "Audio Device";
            audioDeviceCol.Name = "audioDeviceCol";
            // 
            // toggleHotkeyCol
            // 
            toggleHotkeyCol.HeaderText = "Toggle";
            toggleHotkeyCol.Name = "toggleHotkeyCol";
            // 
            // uniqueHotKeyButtonCol
            // 
            uniqueHotKeyButtonCol.HeaderText = "Unique Hotkey (optional)";
            uniqueHotKeyButtonCol.Name = "uniqueHotKeyButtonCol";
            // 
            // audioDevicesBindingSource
            // 
            audioDevicesBindingSource.DataSource = typeof(audioDeviceLibrary.audioDevices);
            // 
            // myDataGridView
            // 
            myDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myDataGridView.Location = new Point(12, 24);
            myDataGridView.Name = "myDataGridView";
            myDataGridView.RowTemplate.Height = 25;
            myDataGridView.Size = new Size(665, 256);
            myDataGridView.TabIndex = 1;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 447);
            Controls.Add(myDataGridView);
            Controls.Add(audioDeviceTable);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "mainForm";
            Text = "SoundSwap";
            ((System.ComponentModel.ISupportInitialize)audioDeviceTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)audioDevicesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)myDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView audioDeviceTable;
        private DataGridViewTextBoxColumn audioDeviceCol;
        private DataGridViewCheckBoxColumn toggleHotkeyCol;
        private DataGridViewButtonColumn uniqueHotKeyButtonCol;
        private BindingSource audioDevicesBindingSource;
        private DataGridView myDataGridView;
    }
}