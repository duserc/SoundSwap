namespace MainForm
{
    partial class SoundSwapMainForm
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
            AudioDeviceGridView = new DataGridView();
            AudioDeviceColumn = new DataGridViewTextBoxColumn();
            enabledBoolColumn = new DataGridViewCheckBoxColumn();
            currentlyPlayingBoolCollumn = new DataGridViewCheckBoxColumn();
            hotkeyStringColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)AudioDeviceGridView).BeginInit();
            SuspendLayout();
            // 
            // AudioDeviceGridView
            // 
            AudioDeviceGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AudioDeviceGridView.Columns.AddRange(new DataGridViewColumn[] { AudioDeviceColumn, enabledBoolColumn, currentlyPlayingBoolCollumn, hotkeyStringColumn });
            AudioDeviceGridView.Location = new Point(12, 12);
            AudioDeviceGridView.Name = "AudioDeviceGridView";
            AudioDeviceGridView.RowTemplate.Height = 25;
            AudioDeviceGridView.Size = new Size(711, 283);
            AudioDeviceGridView.TabIndex = 0;
            // 
            // AudioDeviceColumn
            // 
            AudioDeviceColumn.HeaderText = "Audio Device";
            AudioDeviceColumn.Name = "AudioDeviceColumn";
            // 
            // enabledBoolColumn
            // 
            enabledBoolColumn.HeaderText = "Enabled";
            enabledBoolColumn.Name = "enabledBoolColumn";
            enabledBoolColumn.Resizable = DataGridViewTriState.True;
            // 
            // currentlyPlayingBoolCollumn
            // 
            currentlyPlayingBoolCollumn.HeaderText = "Currently Playing Audio";
            currentlyPlayingBoolCollumn.Name = "currentlyPlayingBoolCollumn";
            currentlyPlayingBoolCollumn.Resizable = DataGridViewTriState.True;
            currentlyPlayingBoolCollumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // hotkeyStringColumn
            // 
            hotkeyStringColumn.HeaderText = "Hotkey";
            hotkeyStringColumn.Name = "hotkeyStringColumn";
            // 
            // SoundSwapMainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(735, 307);
            Controls.Add(AudioDeviceGridView);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "SoundSwapMainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AudioDeviceGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView AudioDeviceGridView;
        private DataGridViewTextBoxColumn AudioDeviceColumn;
        private DataGridViewCheckBoxColumn enabledBoolColumn;
        private DataGridViewCheckBoxColumn currentlyPlayingBoolCollumn;
        private DataGridViewTextBoxColumn hotkeyStringColumn;
    }
}