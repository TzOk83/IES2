using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace IES_2
{
    public partial class SplashScreen : Form
    {
        private double m_dblOpacityIncrement = .1;
        private const int TIMER_INTERVAL = 50;

        public SplashScreen()
        {
            InitializeComponent();
            lblVer.Text = "v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();
            this.ClientSize = this.BackgroundImage.Size;
            this.Opacity = .0;
            timer1.Interval = TIMER_INTERVAL;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += m_dblOpacityIncrement;
            else
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
