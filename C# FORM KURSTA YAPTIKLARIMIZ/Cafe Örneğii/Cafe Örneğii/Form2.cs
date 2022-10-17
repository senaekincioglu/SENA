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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         public double sayi = 0;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKullanici.Text=="sa"&&txtSifre.Text=="1234")
            {
                MessageBox.Show("toplam kasa " + sayi);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }
    }
}
