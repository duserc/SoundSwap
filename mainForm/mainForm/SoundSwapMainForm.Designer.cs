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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundSwapMainForm));
            AudioDeviceGridView = new DataGridView();
            AudioDeviceColumn = new DataGridViewTextBoxColumn();
            enabledBoolColumn = new DataGridViewCheckBoxColumn();
            currentlyPlayingBoolCollumn = new DataGridViewCheckBoxColumn();
            hotkeyStringColumn = new DataGridViewTextBoxColumn();
            SoundSwapContextMenuStrip = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            saveButton = new Button();
            SoundSwapIcon = new NotifyIcon(components);
            SoundSwapMainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toSystemTrayToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            readMeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)AudioDeviceGridView).BeginInit();
            SoundSwapContextMenuStrip.SuspendLayout();
            SoundSwapMainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // AudioDeviceGridView
            // 
            AudioDeviceGridView.AllowUserToAddRows = false;
            AudioDeviceGridView.AllowUserToDeleteRows = false;
            AudioDeviceGridView.AllowUserToResizeColumns = false;
            AudioDeviceGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            AudioDeviceGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AudioDeviceGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AudioDeviceGridView.BackgroundColor = Color.FromArgb(64, 64, 64);
            AudioDeviceGridView.BorderStyle = BorderStyle.Fixed3D;
            AudioDeviceGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AudioDeviceGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AudioDeviceGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AudioDeviceGridView.Columns.AddRange(new DataGridViewColumn[] { AudioDeviceColumn, enabledBoolColumn, currentlyPlayingBoolCollumn, hotkeyStringColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AudioDeviceGridView.DefaultCellStyle = dataGridViewCellStyle3;
            AudioDeviceGridView.GridColor = Color.Black;
            AudioDeviceGridView.Location = new Point(12, 40);
            AudioDeviceGridView.Name = "AudioDeviceGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            AudioDeviceGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            AudioDeviceGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.Gray;
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            AudioDeviceGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            AudioDeviceGridView.RowTemplate.ContextMenuStrip = SoundSwapContextMenuStrip;
            AudioDeviceGridView.RowTemplate.Height = 25;
            AudioDeviceGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            AudioDeviceGridView.Size = new Size(619, 226);
            AudioDeviceGridView.TabIndex = 0;
            AudioDeviceGridView.CellContentClick += AudioDeviceGridView_CellContentClick;
            // 
            // AudioDeviceColumn
            // 
            AudioDeviceColumn.Frozen = true;
            AudioDeviceColumn.HeaderText = "Audio Device";
            AudioDeviceColumn.Name = "AudioDeviceColumn";
            AudioDeviceColumn.ReadOnly = true;
            AudioDeviceColumn.Width = 337;
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
            currentlyPlayingBoolCollumn.Visible = false;
            currentlyPlayingBoolCollumn.Width = 93;
            // 
            // hotkeyStringColumn
            // 
            hotkeyStringColumn.HeaderText = "Hotkey";
            hotkeyStringColumn.Name = "hotkeyStringColumn";
            hotkeyStringColumn.Width = 185;
            // 
            // SoundSwapContextMenuStrip
            // 
            SoundSwapContextMenuStrip.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, quitToolStripMenuItem });
            SoundSwapContextMenuStrip.Name = "SoundSwapContextMenuStrip";
            SoundSwapContextMenuStrip.Size = new Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(103, 22);
            quitToolStripMenuItem.Text = "&Quit";
            quitToolStripMenuItem.MouseDown += quitToolStripMenuItem_MouseDown;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(535, 272);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(96, 37);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // SoundSwapIcon
            // 
            SoundSwapIcon.Icon = (Icon)resources.GetObject("SoundSwapIcon.Icon");
            SoundSwapIcon.Text = "SoundSwap";
            SoundSwapIcon.Visible = true;
            SoundSwapIcon.DoubleClick += NotifyIcon_DoubleClick;
            // 
            // SoundSwapMainMenuStrip
            // 
            SoundSwapMainMenuStrip.BackColor = Color.DimGray;
            SoundSwapMainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            SoundSwapMainMenuStrip.Location = new Point(0, 0);
            SoundSwapMainMenuStrip.Name = "SoundSwapMainMenuStrip";
            SoundSwapMainMenuStrip.RenderMode = ToolStripRenderMode.System;
            SoundSwapMainMenuStrip.Size = new Size(655, 24);
            SoundSwapMainMenuStrip.TabIndex = 2;
            SoundSwapMainMenuStrip.Text = "SoundSwapMainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = Color.DarkGray;
            saveToolStripMenuItem.ImageTransparentColor = Color.DimGray;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(98, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.DarkGray;
            exitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toSystemTrayToolStripMenuItem, quitToolStripMenuItem1 });
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(98, 22);
            exitToolStripMenuItem.Text = "&Exit";
            // 
            // toSystemTrayToolStripMenuItem
            // 
            toSystemTrayToolStripMenuItem.Name = "toSystemTrayToolStripMenuItem";
            toSystemTrayToolStripMenuItem.Size = new Size(151, 22);
            toSystemTrayToolStripMenuItem.Text = "&To System Tray";
            // 
            // quitToolStripMenuItem1
            // 
            quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            quitToolStripMenuItem1.Size = new Size(151, 22);
            quitToolStripMenuItem1.Text = "&Quit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { readMeToolStripMenuItem });
            helpToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            helpToolStripMenuItem.ImageTransparentColor = Color.DimGray;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // readMeToolStripMenuItem
            // 
            readMeToolStripMenuItem.BackColor = Color.DarkGray;
            readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            readMeToolStripMenuItem.Size = new Size(117, 22);
            readMeToolStripMenuItem.Text = "&ReadMe";
            // 
            // SoundSwapMainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(655, 321);
            Controls.Add(SoundSwapMainMenuStrip);
            Controls.Add(saveButton);
            Controls.Add(AudioDeviceGridView);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.NoControl;
            MainMenuStrip = SoundSwapMainMenuStrip;
            Margin = new Padding(5);
            Name = "SoundSwapMainForm";
            ShowIcon = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SoundSwap";
            FormClosing += SoundSwapMainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)AudioDeviceGridView).EndInit();
            SoundSwapContextMenuStrip.ResumeLayout(false);
            SoundSwapMainMenuStrip.ResumeLayout(false);
            SoundSwapMainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AudioDeviceGridView;
        private Button saveButton;
        private ContextMenuStrip SoundSwapContextMenuStrip;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private MenuStrip SoundSwapMainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem readMeToolStripMenuItem;
        private ToolStripMenuItem toSystemTrayToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem1;
        private DataGridViewTextBoxColumn AudioDeviceColumn;
        private DataGridViewCheckBoxColumn enabledBoolColumn;
        private DataGridViewCheckBoxColumn currentlyPlayingBoolCollumn;
        private DataGridViewTextBoxColumn hotkeyStringColumn;
        private NotifyIcon SoundSwapIcon;
    }
}