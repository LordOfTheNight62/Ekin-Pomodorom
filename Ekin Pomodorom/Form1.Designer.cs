namespace Ekin_Pomodorom
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            comboBoxTime = new ComboBox();
            startBtn = new Button();
            timeLabel = new Label();
            pauseBtn = new Button();
            resetBtn = new Button();
            dailyStatsLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTime
            // 
            comboBoxTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTime.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxTime.FormattingEnabled = true;
            comboBoxTime.ImeMode = ImeMode.NoControl;
            comboBoxTime.IntegralHeight = false;
            comboBoxTime.ItemHeight = 31;
            comboBoxTime.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30" });
            comboBoxTime.Location = new Point(5, 6);
            comboBoxTime.MaxDropDownItems = 10;
            comboBoxTime.Name = "comboBoxTime";
            comboBoxTime.Size = new Size(52, 39);
            comboBoxTime.TabIndex = 0;
            comboBoxTime.SelectedIndexChanged += comboBoxTime_SelectedIndexChanged;
            // 
            // startBtn
            // 
            startBtn.Anchor = AnchorStyles.Top;
            startBtn.BackColor = Color.Chartreuse;
            startBtn.BackgroundImage = Properties.Resources.play;
            startBtn.BackgroundImageLayout = ImageLayout.Stretch;
            startBtn.Cursor = Cursors.Hand;
            startBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            startBtn.Location = new Point(152, 133);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(70, 70);
            startBtn.TabIndex = 1;
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // timeLabel
            // 
            timeLabel.Anchor = AnchorStyles.Top;
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 70.2000046F, FontStyle.Regular, GraphicsUnit.Point, 162);
            timeLabel.Location = new Point(96, -26);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(347, 156);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "00:00";
            // 
            // pauseBtn
            // 
            pauseBtn.Anchor = AnchorStyles.Top;
            pauseBtn.BackColor = Color.DeepSkyBlue;
            pauseBtn.BackgroundImage = Properties.Resources.play_pause;
            pauseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            pauseBtn.Cursor = Cursors.Hand;
            pauseBtn.Enabled = false;
            pauseBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            pauseBtn.Location = new Point(228, 133);
            pauseBtn.Name = "pauseBtn";
            pauseBtn.Size = new Size(70, 70);
            pauseBtn.TabIndex = 3;
            pauseBtn.UseVisualStyleBackColor = false;
            pauseBtn.Click += pauseBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Anchor = AnchorStyles.Top;
            resetBtn.BackColor = Color.Red;
            resetBtn.BackgroundImage = Properties.Resources.refresh;
            resetBtn.BackgroundImageLayout = ImageLayout.Stretch;
            resetBtn.Cursor = Cursors.Hand;
            resetBtn.Enabled = false;
            resetBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            resetBtn.ForeColor = Color.WhiteSmoke;
            resetBtn.Location = new Point(304, 133);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(70, 70);
            resetBtn.TabIndex = 4;
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // dailyStatsLabel
            // 
            dailyStatsLabel.Anchor = AnchorStyles.Bottom;
            dailyStatsLabel.AutoSize = true;
            dailyStatsLabel.BackColor = Color.MediumBlue;
            dailyStatsLabel.FlatStyle = FlatStyle.System;
            dailyStatsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dailyStatsLabel.ForeColor = Color.White;
            dailyStatsLabel.Location = new Point(74, 220);
            dailyStatsLabel.Name = "dailyStatsLabel";
            dailyStatsLabel.Padding = new Padding(2);
            dailyStatsLabel.Size = new Size(378, 88);
            dailyStatsLabel.TabIndex = 8;
            dailyStatsLabel.Text = "Bugünlük Çalışma Sürem: 0 saat 0 dk, \r\nPomodoro Sayım: 0\r\n";
            dailyStatsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.EKİN;
            pictureBox1.Location = new Point(63, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(528, 289);
            Controls.Add(pictureBox1);
            Controls.Add(resetBtn);
            Controls.Add(pauseBtn);
            Controls.Add(startBtn);
            Controls.Add(dailyStatsLabel);
            Controls.Add(comboBoxTime);
            Controls.Add(timeLabel);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pomodorom - Ekin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTime;
        private Button startBtn;
        private Label timeLabel;
        private Button pauseBtn;
        private Button resetBtn;
        private Label dailyStatsLabel;
        private PictureBox pictureBox1;
    }
}
