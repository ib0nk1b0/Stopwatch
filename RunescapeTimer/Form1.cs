using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;

namespace RunescapeTimer
{
    public partial class Form1 : Form
    {
        private int _ticks = 0;
        private Stopwatch _stopwatch;
        private System.Timers.Timer _timer;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            this.Text = "Timer";
            _stopwatch = new Stopwatch();
            _timer = new System.Timers.Timer(1);
            _timer.Elapsed += OnTimerElapse;
        }

        private void OnTimerElapse(object sender, ElapsedEventArgs e)
        {
            Invoke(() => { label1.Text = _stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.FFF"); });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = _ticks.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_stopwatch.IsRunning)
            {
                _stopwatch.Start();
                _timer.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_stopwatch.IsRunning)
            {
                _stopwatch.Stop();
                _timer.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _stopwatch.Stop();
            _timer.Stop();
            _stopwatch.Reset();
            label1.Text = "00:00:00.000";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}