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
            newToolStripMenuItem1 = new ToolStripMenuItem();
            detectNewAudioDeviceToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toSystemTrayToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem1 = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            launchOnSystemStartupToolStripMenuItem = new ToolStripMenuItem();
            yesToolStripMenuItem = new ToolStripMenuItem();
            noToolStripMenuItem = new ToolStripMenuItem();
            resetConfigToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            readMeToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            VersionNumbertoolStripStatusLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)AudioDeviceGridView).BeginInit();
            SoundSwapContextMenuStrip.SuspendLayout();
            SoundSwapMainMenuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
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
            AudioDeviceGridView.Location = new Point(19, 40);
            AudioDeviceGridView.Margin = new Padding(10, 3, 10, 3);
            AudioDeviceGridView.MaximumSize = new Size(616, 226);
            AudioDeviceGridView.MinimumSize = new Size(616, 226);
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
            AudioDeviceGridView.Size = new Size(616, 226);
            AudioDeviceGridView.TabIndex = 0;
            AudioDeviceGridView.CellContentClick += AudioDeviceGridView_CellContentClick;
            AudioDeviceGridView.EditingControlShowing += AudioDeviceGridView_EditingControlShowing;
            // 
            // AudioDeviceColumn
            // 
            AudioDeviceColumn.Frozen = true;
            AudioDeviceColumn.HeaderText = "Audio Device";
            AudioDeviceColumn.Name = "AudioDeviceColumn";
            AudioDeviceColumn.ReadOnly = true;
            AudioDeviceColumn.Width = 335;
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
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            quitToolStripMenuItem.MouseDown += quitToolStripMenuItem_MouseDown;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveButton.Location = new Point(549, 272);
            saveButton.MaximumSize = new Size(86, 40);
            saveButton.MinimumSize = new Size(86, 40);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(86, 40);
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
            SoundSwapIcon.MouseDoubleClick += SoundSwapIcon_MouseDoubleClick;
            // 
            // SoundSwapMainMenuStrip
            // 
            SoundSwapMainMenuStrip.BackColor = Color.DimGray;
            SoundSwapMainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem, helpToolStripMenuItem });
            SoundSwapMainMenuStrip.Location = new Point(0, 0);
            SoundSwapMainMenuStrip.Name = "SoundSwapMainMenuStrip";
            SoundSwapMainMenuStrip.RenderMode = ToolStripRenderMode.System;
            SoundSwapMainMenuStrip.Size = new Size(654, 24);
            SoundSwapMainMenuStrip.TabIndex = 2;
            SoundSwapMainMenuStrip.Text = "SoundSwapMainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem1, saveToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem1
            // 
            newToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { detectNewAudioDeviceToolStripMenuItem });
            newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            newToolStripMenuItem1.Size = new Size(98, 22);
            newToolStripMenuItem1.Text = "&New";
            // 
            // detectNewAudioDeviceToolStripMenuItem
            // 
            detectNewAudioDeviceToolStripMenuItem.Name = "detectNewAudioDeviceToolStripMenuItem";
            detectNewAudioDeviceToolStripMenuItem.Size = new Size(208, 22);
            detectNewAudioDeviceToolStripMenuItem.Text = "&Detect New Audio Device";
            detectNewAudioDeviceToolStripMenuItem.Click += detectNewAudioDeviceToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = Color.DarkGray;
            saveToolStripMenuItem.ImageTransparentColor = Color.DimGray;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(98, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(95, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.DarkGray;
            exitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toSystemTrayToolStripMenuItem, quitToolStripMenuItem1 });
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(98, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // toSystemTrayToolStripMenuItem
            // 
            toSystemTrayToolStripMenuItem.Name = "toSystemTrayToolStripMenuItem";
            toSystemTrayToolStripMenuItem.Size = new Size(151, 22);
            toSystemTrayToolStripMenuItem.Text = "&To System Tray";
            toSystemTrayToolStripMenuItem.Click += toSystemTrayToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem1
            // 
            quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            quitToolStripMenuItem1.Size = new Size(151, 22);
            quitToolStripMenuItem1.Text = "&Quit";
            quitToolStripMenuItem1.Click += quitToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { launchOnSystemStartupToolStripMenuItem, resetConfigToolStripMenuItem });
            settingsToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "S&ettings";
            // 
            // launchOnSystemStartupToolStripMenuItem
            // 
            launchOnSystemStartupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yesToolStripMenuItem, noToolStripMenuItem });
            launchOnSystemStartupToolStripMenuItem.Name = "launchOnSystemStartupToolStripMenuItem";
            launchOnSystemStartupToolStripMenuItem.Size = new Size(217, 22);
            launchOnSystemStartupToolStripMenuItem.Text = "&Launch on System Startup?";
            // 
            // yesToolStripMenuItem
            // 
            yesToolStripMenuItem.Name = "yesToolStripMenuItem";
            yesToolStripMenuItem.Size = new Size(91, 22);
            yesToolStripMenuItem.Text = "&Yes";
            yesToolStripMenuItem.Click += yesToolStripMenuItem_Click;
            // 
            // noToolStripMenuItem
            // 
            noToolStripMenuItem.Name = "noToolStripMenuItem";
            noToolStripMenuItem.Size = new Size(91, 22);
            noToolStripMenuItem.Text = "&No";
            noToolStripMenuItem.Click += noToolStripMenuItem_Click;
            // 
            // resetConfigToolStripMenuItem
            // 
            resetConfigToolStripMenuItem.Name = "resetConfigToolStripMenuItem";
            resetConfigToolStripMenuItem.Size = new Size(217, 22);
            resetConfigToolStripMenuItem.Text = "&Reset Config and Program";
            resetConfigToolStripMenuItem.Click += resetConfigToolStripMenuItem_Click;
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
            readMeToolStripMenuItem.Click += readMeToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.DarkGray;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripStatusLabel1, VersionNumbertoolStripStatusLabel });
            statusStrip1.Location = new Point(0, 315);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(654, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // VersionNumbertoolStripStatusLabel
            // 
            VersionNumbertoolStripStatusLabel.Name = "VersionNumbertoolStripStatusLabel";
            VersionNumbertoolStripStatusLabel.Size = new Size(467, 17);
            VersionNumbertoolStripStatusLabel.Spring = true;
            VersionNumbertoolStripStatusLabel.Text = "Version: ";
            VersionNumbertoolStripStatusLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SoundSwapMainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(654, 337);
            Controls.Add(statusStrip1);
            Controls.Add(SoundSwapMainMenuStrip);
            Controls.Add(saveButton);
            Controls.Add(AudioDeviceGridView);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = SoundSwapMainMenuStrip;
            Margin = new Padding(5);
            Name = "SoundSwapMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SoundSwap";
            FormClosing += SoundSwapMainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)AudioDeviceGridView).EndInit();
            SoundSwapContextMenuStrip.ResumeLayout(false);
            SoundSwapMainMenuStrip.ResumeLayout(false);
            SoundSwapMainMenuStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem detectNewAudioDeviceToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem launchOnSystemStartupToolStripMenuItem;
        private ToolStripMenuItem yesToolStripMenuItem;
        private ToolStripMenuItem noToolStripMenuItem;
        private ToolStripMenuItem resetConfigToolStripMenuItem;
        private ToolStripStatusLabel VersionNumbertoolStripStatusLabel;
    }
}