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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            audioDeviceTable = new DataGridView();
            audioDeviceCol = new DataGridViewTextBoxColumn();
            activeHotkeyCol = new DataGridViewCheckBoxColumn();
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
            audioDeviceTable.Columns.AddRange(new DataGridViewColumn[] { audioDeviceCol, activeHotkeyCol, uniqueHotKeyButtonCol });
            audioDeviceTable.DataSource = audioDevicesBindingSource;
            audioDeviceTable.Location = new Point(12, 286);
            audioDeviceTable.Name = "audioDeviceTable";
            audioDeviceTable.RowTemplate.Height = 25;
            audioDeviceTable.Size = new Size(665, 149);
            audioDeviceTable.TabIndex = 0;
            audioDeviceTable.VirtualMode = true;
            audioDeviceTable.Visible = false;
            // 
            // audioDeviceCol
            // 
            audioDeviceCol.HeaderText = "Audio Device";
            audioDeviceCol.Name = "audioDeviceCol";
            // 
            // activeHotkeyCol
            // 
            activeHotkeyCol.HeaderText = "Active";
            activeHotkeyCol.Name = "activeHotkeyCol";
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
            myDataGridView.AllowUserToAddRows = false;
            myDataGridView.AllowUserToDeleteRows = false;
            myDataGridView.AllowUserToResizeColumns = false;
            myDataGridView.AllowUserToResizeRows = false;
            myDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            myDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            myDataGridView.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            myDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            myDataGridView.ColumnHeadersHeight = 42;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            myDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            myDataGridView.Dock = DockStyle.Fill;
            myDataGridView.EditMode = DataGridViewEditMode.EditOnF2;
            myDataGridView.GridColor = Color.Gainsboro;
            myDataGridView.Location = new Point(0, 0);
            myDataGridView.Name = "myDataGridView";
            myDataGridView.RowTemplate.Height = 25;
            myDataGridView.ScrollBars = ScrollBars.None;
            myDataGridView.Size = new Size(805, 525);
            myDataGridView.TabIndex = 1;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 525);
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
        private BindingSource audioDevicesBindingSource;
        private DataGridViewTextBoxColumn audioDeviceCol;
        private DataGridViewCheckBoxColumn activeHotkeyCol;
        private DataGridViewButtonColumn uniqueHotKeyButtonCol;
        public DataGridView audioDeviceTable;
        private DataGridView myDataGridView;
    }
}