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
            SoundDevicelabel = new Label();
            SuspendLayout();
            // 
            // SoundDevicelabel
            // 
            SoundDevicelabel.Dock = DockStyle.Fill;
            SoundDevicelabel.Location = new Point(0, 0);
            SoundDevicelabel.Name = "SoundDevicelabel";
            SoundDevicelabel.Size = new Size(299, 113);
            SoundDevicelabel.TabIndex = 0;
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
            ResumeLayout(false);
        }

        #endregion

        private Label SoundDevicelabel;
    }
}