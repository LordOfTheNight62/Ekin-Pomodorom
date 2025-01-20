using System.Diagnostics;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace Ekin_Pomodorom
{
    public partial class MainForm : Form
    {
        // API �a�r�lar�
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int HOTKEY_ID = 1; // Hotkey i�in ID (benzersiz olmal�)
        private const uint MOD_ALT = 0x0001; // ALT tu�u
        private const uint VK_NUMPAD0 = 0x60; // Numpad �zerindeki '0' tu�u

        private Timer countdownTimer;
        private const int DEFAULT_TIME = 15*60;
        private int time = DEFAULT_TIME;
        private bool isStarted = false;
        private bool isPaused = false;
        private int dailyWorkSeconds = 0;
        private int pomodoroCount = 0;
        private DateTime lastOpenedDate;

        public MainForm()
        {
            InitializeComponent();
            LoadDailyData();
            UpdateDailyStatsLabel();
            comboBoxTime.SelectedIndex = 2;
            // Timer'� ba�lat
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // Timer 1 saniyede bir �al��acak
            countdownTimer.Tick += CountdownTimer;
            RegisterHotKey(this.Handle, HOTKEY_ID, MOD_ALT, VK_NUMPAD0);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDailyData();
            // Uygulama kapan�rken hotkey kayd�n� kald�r
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            base.OnFormClosing(e);
        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isStarted)
            {
                return;
            }
            switch (comboBoxTime.SelectedIndex)
            {
                case 0: // 5 dakika
                    time = 5*60;
                    break;
                case 1: // 10 dakika
                    time = 10 * 60;
                    break;
                case 2: // 15 dakika
                    time = 15 * 60;
                    break;
                case 3: // 20 dakika
                    time = 20 * 60;
                    break;
                case 4: // 25 dakika
                    time = 25 * 60;
                    break;
                case 5: // 30 dakika
                    time = 30 * 60;
                    break;
            }
            SetTimeLabel();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // Timer'� ba�lat
            countdownTimer.Start();
            comboBoxTime.Enabled = false;
            startBtn.Enabled = false;
            pauseBtn.Enabled = true;
            resetBtn.Enabled = true;
            isStarted = true;
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                countdownTimer.Start();
                timeLabel.ForeColor = Color.Black;
            }
            else
            {
                countdownTimer.Stop();
                timeLabel.ForeColor = Color.Red;
            }
            isPaused = !isPaused;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            time = comboBoxTime.SelectedIndex;
            comboBoxTime.Enabled = true;
            startBtn.Enabled = true;
            pauseBtn.Enabled = false;
            resetBtn.Enabled = false;
            isStarted = false;
            time = DEFAULT_TIME;
            comboBoxTime.SelectedIndex = 2;
            SetTimeLabel();
            timeLabel.ForeColor = Color.Black;
        }

        private void CountdownTimer(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
            }

            if (time <= 0)
            {
                dailyWorkSeconds += Convert.ToInt32(comboBoxTime.SelectedItem)*60; // Pomodoro s�resini ekle
                pomodoroCount++;

                MessageForm form2 = new MessageForm();
                countdownTimer.Stop();
                SetTimeLabel();
                form2.ShowDialog();
                UpdateDailyStatsLabel();
                SaveDailyData(); // Verileri kaydet
                pauseBtn.Enabled = false;
            }
            else
            {
                SetTimeLabel();
            }
        }

        private void SetTimeLabel()
        {
            int minutes = time / 60;
            int seconds = time % 60;
            timeLabel.Text = $"{minutes:D2}:{seconds:D2}";
        }

        private void UpdateDailyStatsLabel()
        {
            int hours = dailyWorkSeconds / 3600;
            int minutes = (dailyWorkSeconds % 3600) / 60;
            dailyStatsLabel.Text = $"Bug�nl�k �al��ma S�rem: {hours} saat {minutes} dk\nPomodoro Say�m: {pomodoroCount}";
        }


        private void LoadDailyData()
        {
            if (Properties.Settings.Default.LastOpenedDate == new DateTime(2025, 1, 1))
            {
                Properties.Settings.Default.LastOpenedDate = DateTime.Today;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.LastOpenedDate.Date != DateTime.Today)
            {
                // Yeni g�n, verileri s�f�rla
                Properties.Settings.Default.DailyWorkSeconds = 0;
                Properties.Settings.Default.PomodoroCount = 0;
            }

            dailyWorkSeconds = Properties.Settings.Default.DailyWorkSeconds;
            pomodoroCount = Properties.Settings.Default.PomodoroCount;
            lastOpenedDate = Properties.Settings.Default.LastOpenedDate;
        }

        private void SaveDailyData()
        {
            Properties.Settings.Default.DailyWorkSeconds = dailyWorkSeconds;
            Properties.Settings.Default.PomodoroCount = pomodoroCount;
            Properties.Settings.Default.LastOpenedDate = DateTime.Today;
            Properties.Settings.Default.Save();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
            {
                // HotKey alg�land�
                if (this.WindowState == FormWindowState.Minimized)
                {
                    // E�er form minimize edilmi�se, ekrana getir
                    this.WindowState = FormWindowState.Normal;
                    this.BringToFront();
                }
                else
                {
                    // E�er form a��k durumdaysa, minimize et
                    this.WindowState = FormWindowState.Minimized;
                }
            }
            base.WndProc(ref m);
        }
    }
}
