using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrobüs_Ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sure;
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sure++;
            if (sure >= 0 && sure <= 60)
            {
                lblOkişareti.Text = "-" + lblOkişareti.Text;
                pictureBox1.Left += 4;
            }
            if (sure >= 60 && sure <= 80)
            {
                Random r = new Random();
                lblSogutlucesme.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 80 && sure <= 140)
            {
                if (sure >= 90 && sure <= 120)
                {
                    lblOkişareti.Text = "-" + lblOkişareti.Text;
                }
                lblSogutlucesme.BackColor = Color.DarkGray;
                pictureBox1.Left += 4;

            }
            if (sure >= 140 && sure <= 160)
            {
                Random r = new Random();
                lblFikirtepe.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 160 && sure <= 220)
            {
                if (sure >= 165 && sure <= 215)
                {
                    lblOkişareti.Text = "-" + lblOkişareti.Text;
                }

                lblFikirtepe.BackColor = Color.DarkGray;
                pictureBox1.Left += 4;
            }
            if (sure >= 220 && sure <= 240)
            {
                // MessageBox.Show(pictureBox1.Left.ToString());

                Random r = new Random();
                lblUzuncayir.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 240 && sure <= 300)
            {
                if (sure >= 250 && sure <= 290)
                {
                    lblOkişareti.Text = "-" + lblOkişareti.Text;
                }
                lblUzuncayir.BackColor = Color.DarkGray;
                pictureBox1.Left += 4;
            }
            if (sure >= 300 && sure <= 320)
            {
                //   MessageBox.Show(pictureBox1.Left.ToString());
                Random r = new Random();
                lblAcibadem.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure == 321)
            {
                lblAcibadem.BackColor = Color.DarkGray;
                timer2.Stop();
            }

        }

        private void btnBaslatdönüs_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblOkişareti.Text = "<--";
            lblAcibadem.BackColor = Color.Transparent;
            lblFikirtepe.BackColor = Color.Transparent;
            lblUzuncayir.BackColor = Color.Transparent;
            lblSogutlucesme.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
