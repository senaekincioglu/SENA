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

namespace Banka_Ödevi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double kreditutar;
        double vade;
        double hesapla;
        private void btnGoster_Click(object sender, EventArgs e)
        {
            kreditutar = Convert.ToInt32(txtKreditutar.Text);
            vade = Convert.ToDouble(txtVade.Text);
            hesapla = kreditutar + (vade * 1.9 / 120);
            label1.Text = hesapla.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnKredigoster_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= vade; i++)
            {
                string cevap = Convert.ToString(txtkredikapatma.Text);
                if (txtkredikapatma.Text == "evet")
                {
                    double taksit;
                    taksit = kreditutar / vade;
                    string kapatmak;
                    kapatmak = Convert.ToString(txtkredikapatma.Text);
                    if (kapatmak == "evet")
                    {
                        taksit = taksit - (taksit * 0.19);
                        label7.Text = "Faiz tutarı " + taksit.ToString();
                        label5.Text = "Aylık taksit tutarı "+(taksit / vade).ToString();
                        label6.Text = "Anapara= " + (hesapla / vade - taksit);

                    }
                    











                }
            }
        }
    }
}
