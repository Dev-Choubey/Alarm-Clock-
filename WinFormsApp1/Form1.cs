using System.Media;

namespace WinFormsApp1
{
    public partial class Alarm : Form
    {
        System.Timers.Timer timer;
        public Alarm()
        {
            InitializeComponent();
        }
        delegate void updatelabel(Label lbl, string value);
        void updateDatalabel(Label lbl, string value)
        {
            lbl.Text = value;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += dateTimePicker1_ValueChanged;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            DateTime user = dateTimePicker1.Value;
            if (current.Hour == user.Hour && current.Minute == user.Minute && current.Second == user.Second)
            {
                timer.Stop();
                updatelabel upd = updateDatalabel;
                if (lblStatus.InvokeRequired)
                {
                    Invoke(upd, lblStatus, "Running...");
                }
                SoundPlayer soundPlayer = new SoundPlayer();
                soundPlayer.SoundLocation = @"C:\Users\PC\source\repos\WinFormsApp1\mixkit-classic-alarm-995.wav";
                soundPlayer.Play();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer.Start();
            lblStatus.Text = "Running...";
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblStatus.Text = "stop";
        }
    }
}