using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("HH:MM");
            secondsLabel.Text = DateTime.Now.ToString("ss");
            dateLabel.Text = DateTime.Now.ToString("dd MMMM yyyy");
            weekDayLabel.Text = DateTime.Now.ToString("dddd");
            secondsLabel.Location = new Point(clockLabel.Location.X + clockLabel.Width, clockLabel.Location.Y);

        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
