namespace AssignHotkeyForm
{
    partial class HotKeyForm
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
            hotkeyinputTextBox = new TextBox();
            hotkeyLabel = new Label();
            SuspendLayout();
            // 
            // hotkeyinputTextBox
            // 
            hotkeyinputTextBox.Location = new Point(94, 17);
            hotkeyinputTextBox.Margin = new Padding(5);
            hotkeyinputTextBox.Name = "hotkeyinputTextBox";
            hotkeyinputTextBox.PlaceholderText = "Eg: Ctrl, Alt + 1";
            hotkeyinputTextBox.Size = new Size(155, 33);
            hotkeyinputTextBox.TabIndex = 0;
            // 
            // hotkeyLabel
            // 
            hotkeyLabel.AutoSize = true;
            hotkeyLabel.ForeColor = Color.White;
            hotkeyLabel.Location = new Point(12, 20);
            hotkeyLabel.Name = "hotkeyLabel";
            hotkeyLabel.Size = new Size(74, 25);
            hotkeyLabel.TabIndex = 1;
            hotkeyLabel.Text = "Hotkey:";
            // 
            // HotKeyForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(273, 63);
            Controls.Add(hotkeyLabel);
            Controls.Add(hotkeyinputTextBox);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "HotKeyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign Hotkey";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox hotkeyinputTextBox;
        private Label hotkeyLabel;
    }
}