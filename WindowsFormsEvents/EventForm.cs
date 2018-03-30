using System;
using System.Windows.Forms;

namespace WindowsFormsEvents
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void button_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show($@"Button pressed: {sender.ToString()}.");
        }



        private void InitializeTimer()
        {
            timer.Interval = 100;
            timer.Start();
            timer.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBarShort.Value < 100)
                progressBarShort.Value++;

            if (progressBarLong.Value < 100)
                progressBarLong.Value++;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
    }
}
