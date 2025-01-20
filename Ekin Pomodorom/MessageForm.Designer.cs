namespace Ekin_Pomodorom
{
    partial class MessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            label1 = new Label();
            okBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 61.8000031F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(570, 139);
            label1.TabIndex = 0;
            label1.Text = "Süre Doldu";
            // 
            // okBtn
            // 
            okBtn.BackColor = SystemColors.ActiveCaptionText;
            okBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            okBtn.ForeColor = SystemColors.ControlLightLight;
            okBtn.Location = new Point(12, 167);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(592, 65);
            okBtn.TabIndex = 1;
            okBtn.Text = "Tamam";
            okBtn.UseVisualStyleBackColor = false;
            okBtn.Click += okBtn_Click;
            // 
            // MessageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 244);
            Controls.Add(okBtn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MessageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Süre Doldu";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button okBtn;
    }
}