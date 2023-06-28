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
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AudioDeviceGridView).BeginInit();
            SuspendLayout();
            // 
            // AudioDeviceGridView
            // 
            AudioDeviceGridView.AllowUserToAddRows = false;
            AudioDeviceGridView.AllowUserToDeleteRows = false;
            AudioDeviceGridView.AllowUserToOrderColumns = true;
            AudioDeviceGridView.AllowUserToResizeColumns = false;
            AudioDeviceGridView.AllowUserToResizeRows = false;
            AudioDeviceGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AudioDeviceGridView.Columns.AddRange(new DataGridViewColumn[] { AudioDeviceColumn, enabledBoolColumn, currentlyPlayingBoolCollumn, hotkeyStringColumn });
            AudioDeviceGridView.GridColor = Color.DimGray;
            AudioDeviceGridView.Location = new Point(0, 0);
            AudioDeviceGridView.Name = "AudioDeviceGridView";
            AudioDeviceGridView.RowHeadersVisible = false;
            AudioDeviceGridView.RowTemplate.Height = 25;
            AudioDeviceGridView.Size = new Size(723, 198);
            AudioDeviceGridView.TabIndex = 0;
            AudioDeviceGridView.CellContentClick += AudioDeviceGridView_CellContentClick;
            // 
            // AudioDeviceColumn
            // 
            AudioDeviceColumn.HeaderText = "Audio Device";
            AudioDeviceColumn.Name = "AudioDeviceColumn";
            AudioDeviceColumn.ReadOnly = true;
            AudioDeviceColumn.Width = 350;
            // 
            // enabledBoolColumn
            // 
            enabledBoolColumn.HeaderText = "Enabled";
            enabledBoolColumn.Name = "enabledBoolColumn";
            enabledBoolColumn.Resizable = DataGridViewTriState.True;
            enabledBoolColumn.Width = 93;
            // 
            // currentlyPlayingBoolCollumn
            // 
            currentlyPlayingBoolCollumn.HeaderText = "Currently Playing Audio";
            currentlyPlayingBoolCollumn.Name = "currentlyPlayingBoolCollumn";
            currentlyPlayingBoolCollumn.Resizable = DataGridViewTriState.True;
            currentlyPlayingBoolCollumn.SortMode = DataGridViewColumnSortMode.Automatic;
            currentlyPlayingBoolCollumn.Width = 93;
            // 
            // hotkeyStringColumn
            // 
            hotkeyStringColumn.HeaderText = "Hotkey";
            hotkeyStringColumn.Name = "hotkeyStringColumn";
            hotkeyStringColumn.Width = 185;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(627, 258);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(96, 37);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // SoundSwapMainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(735, 307);
            Controls.Add(saveButton);
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
        private Button saveButton;
        private DataGridViewTextBoxColumn AudioDeviceColumn;
        private DataGridViewCheckBoxColumn enabledBoolColumn;
        private DataGridViewCheckBoxColumn currentlyPlayingBoolCollumn;
        private DataGridViewTextBoxColumn hotkeyStringColumn;
    }
}