using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Örneğii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            cmbTall.Enabled = false; //çalışmasını engeller.
            cmbVenti.Enabled = false;
            cmbGrande.Enabled = false;
            cmbSu.Enabled = false;
        }

        private void chcTall_CheckedChanged(object sender, EventArgs e)
        {
            if(chcTall.Checked==true)
            {
                cmbTall.Enabled = true;
                cmbTall.SelectedIndex = 0;
            }
            else
            {
                cmbTall.Enabled = false;
            }
        }

        private void chcVenti_CheckedChanged(object sender, EventArgs e)
        {
            if (chcVenti.Checked == true)
            {
                cmbVenti.Enabled = true;
                cmbVenti.SelectedIndex = 0;
            }
            else
            {
                cmbVenti.Enabled = false;
            }
        }

        private void chcGrande_CheckedChanged(object sender, EventArgs e)
        {
            if (chcGrande. Checked == true)
            {
                cmbGrande.Enabled = true;
                cmbGrande.SelectedIndex = 0;
            }
            else
            {
                cmbGrande.Enabled = false;
            }
        }

        private void chcSu_CheckedChanged(object sender, EventArgs e)
        {
            if (chcSu.Checked == true)
            {
                cmbSu.Enabled = true;
                cmbSu.SelectedIndex = 0;
            }
            else
            {
                cmbSu.Enabled = false;
            }

        }
        double kahve = 21,kahveAdet;
        double kola = 15,kolaAdet;
        double meyvesuyu = 18,meyveSuyuAdet;
        double su = 5, suAdet;

        private void btnGecis_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
            
            frm2.sayi = toplamKasa;
            
        }

        private void lbl0_Click(object sender, EventArgs e)
        {

        }

        private void btnSatisyap_Click(object sender, EventArgs e)
        {

            toplamKasa += toplamsiparis;
            lbl02.Text = toplamKasa.ToString();
        }

       
        double toplamsiparis=0;
        double toplamKasa = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            toplamsiparis = 0;
            if (chcTall.Checked == true)
            {
                kahveAdet = Convert.ToDouble(cmbTall.Text);
                toplamsiparis = toplamsiparis + (kahveAdet * kahve);
            }
            if (chcVenti.Checked == true)
            {
                kolaAdet = Convert.ToDouble(cmbVenti.Text);
                toplamsiparis = toplamsiparis + (kolaAdet * kola);
            }
            if (chcGrande.Checked == true)
            {
                meyveSuyuAdet = Convert.ToDouble(cmbGrande.Text);
                toplamsiparis = toplamsiparis + (meyveSuyuAdet * meyvesuyu);
            }
            if (chcSu.Checked == true)
            {
                suAdet = Convert.ToDouble(cmbSu.Text);
                toplamsiparis = toplamsiparis + (suAdet * su);
            }
            lbl0.Text=toplamsiparis.ToString();
        }
    }
}
