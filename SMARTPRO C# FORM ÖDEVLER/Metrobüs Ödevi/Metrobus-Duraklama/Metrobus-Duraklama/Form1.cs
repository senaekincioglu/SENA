using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrobus_Duraklama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sure = 0;
        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            timer2.Start();

        }



        private void timer2_Tick(object sender, EventArgs e)
        {

            sure++; ;
            if (sure >= 0 && sure <= 60)
            {
                label1.Text = "-" + label1.Text;
                pictureBox1.Left += 4;
            }
            if (sure >= 60 && sure <= 80)
            {
                Random r = new Random();
                rdSogutlucesme.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 80 && sure <= 140)
            {
                if (sure >= 90 && sure <= 120)
                {
                    label1.Text = "-" + label1.Text;
                }
                rdSogutlucesme.BackColor = Color.DarkGray;
                pictureBox1.Left += 4;

            }
            if (sure >= 140 && sure <= 160)
            {
                Random r = new Random();
                rdFikirtepe.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 160 && sure <= 220)
            {
                if (sure >= 165 && sure <= 215)
                {
                    label1.Text = "-" + label1.Text;
                }

                rdFikirtepe.BackColor = Color.DarkGray;
                pictureBox1.Left += 4;
            }
            if (sure >= 220 && sure <= 240)
            {
                Random r = new Random();
                rdUzuncayir.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 240 && sure <= 300)
            {
                if (sure >= 250 && sure <= 290)
                {
                    label1.Text = "-" + label1.Text;
                }
                rdUzuncayir.BackColor = Color.DarkGray;
                pictureBox1.Left += 4;
            }
            if (sure >= 300 && sure <= 320)
            {
                Random r = new Random();
                rdAcıbadem.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure == 321)
            {
                rdAcıbadem.BackColor = Color.DarkGray;
                timer2.Stop();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            label1.Text = "<--";

            rdAcıbadem.BackColor = Color.Transparent;
            rdFikirtepe.BackColor = Color.Transparent;
            rdUzuncayir.BackColor = Color.Transparent;
            rdSogutlucesme.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rdSogutlucesme.BackColor = Color.GreenYellow;
            rdFikirtepe.BackColor = Color.GreenYellow;
            rdUzuncayir.BackColor = Color.GreenYellow;
            rdAcıbadem.BackColor = Color.GreenYellow;

            label1.TextAlign = ContentAlignment.MiddleRight;
            sure--;
            if (sure >= 0 && sure <= 60)
            {
                if (sure >= 0 && sure <= 60)
                {
                    label1.Text = label1.Text + "-";
                }
                pictureBox1.Left -= 4;
                rdSogutlucesme.BackColor = Color.DarkGray;
            }
            if (sure >= 60 && sure <= 80)
            {
                Random r = new Random();
                rdSogutlucesme.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 80 && sure <= 140)
            {
                if (sure >= 80 && sure <= 125)
                {
                    label1.Text = label1.Text + "-";
                }
                rdFikirtepe.BackColor = Color.DarkGray;
                pictureBox1.Left -= 4;
            }
            if (sure >= 140 && sure <= 160)
            {
                Random r = new Random();
                rdFikirtepe.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 160 && sure <= 220)
            {
                if (sure >= 170 && sure <= 200)
                {
                    label1.Text = label1.Text + "-";
                }
                rdUzuncayir.BackColor = Color.DarkGray;
                pictureBox1.Left -= 4;
            }
            if (sure >= 220 && sure <= 240)
            {
                Random r = new Random();
                rdUzuncayir.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 240 && sure <= 300)
            {
                if (sure >= 240 && sure <= 300)
                {
                    label1.Text = label1.Text + "-";
                }
                rdAcıbadem.BackColor = Color.DarkGray;
                pictureBox1.Left -= 4;
            }

            if (sure >= 300 && sure <= 320)
            {
                Random r = new Random();
                rdAcıbadem.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure == 0)
            {
                timer1.Stop();
            }

        }

       
    }
}
