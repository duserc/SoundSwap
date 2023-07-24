namespace NotificationForm
{
    partial class SoundSwapNotification
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
            volumeSlider = new TrackBar();
            volumeUiLabel = new Label();
            SoundDevicelabel = new Label();
            ((System.ComponentModel.ISupportInitialize)volumeSlider).BeginInit();
            SuspendLayout();
            // 
            // volumeSlider
            // 
            volumeSlider.Location = new Point(0, 69);
            volumeSlider.Maximum = 100;
            volumeSlider.Name = "volumeSlider";
            volumeSlider.Size = new Size(229, 45);
            volumeSlider.TabIndex = 0;
            volumeSlider.ValueChanged += volumeSlider_ValueChanged;
            volumeSlider.MouseLeave += volumeSlider_MouseLeave;
            volumeSlider.MouseHover += volumeSlider_MouseHover;
            // 
            // volumeUiLabel
            // 
            volumeUiLabel.AutoSize = true;
            volumeUiLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            volumeUiLabel.Location = new Point(226, 72);
            volumeUiLabel.Name = "volumeUiLabel";
            volumeUiLabel.Size = new Size(73, 32);
            volumeUiLabel.TabIndex = 1;
            volumeUiLabel.Text = "100%";
            // 
            // SoundDevicelabel
            // 
            SoundDevicelabel.Dock = DockStyle.Fill;
            SoundDevicelabel.Location = new Point(0, 0);
            SoundDevicelabel.Name = "SoundDevicelabel";
            SoundDevicelabel.Padding = new Padding(0, 0, 0, 50);
            SoundDevicelabel.Size = new Size(299, 113);
            SoundDevicelabel.TabIndex = 7;
            SoundDevicelabel.Text = "CurrentSoundDeviceName";
            SoundDevicelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SoundSwapNotification
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(299, 113);
            ControlBox = false;
            Controls.Add(volumeUiLabel);
            Controls.Add(volumeSlider);
            Controls.Add(SoundDevicelabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SoundSwapNotification";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.Manual;
            Text = "SoundSwapNotification";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)volumeSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar volumeSlider;
        private Label volumeUiLabel;
        private Label SoundDevicelabel;
    }
}