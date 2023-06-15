using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Homework
{
    public partial class ScreenSaver : Form
    {

        private Timer timer;
        private int x, y;
        private int directionX = 1, directionY = 1;

        public ScreenSaver()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();

            this.MouseClick += ScreenSaver_MouseClick;
            //this.MouseMove += ScreenSaver_MouseMove;
        }
       

        private void Timer_Tick(object sender, EventArgs e)
        {
            x += directionX;
            y += directionY;

            if (x + pictureBox1.Width >= this.ClientSize.Width || x <= 0)
            {
                directionX *= -1;
            }

            if (y + pictureBox1.Height >= this.ClientSize.Height || y <= 0)
            {
                directionY *= -1;
            }

            pictureBox1.Location = new Point(x, y);
        }
        private void ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close(); 
        }

        //private void ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        //{
        //    this.Close();
        //}


    }
}

