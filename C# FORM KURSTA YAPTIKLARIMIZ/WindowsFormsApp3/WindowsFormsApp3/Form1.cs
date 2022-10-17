using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double sayi1, sayi2,sonuc=0;

            sayi1 = Convert.ToDouble(txtSayıbir.Text);//sayı 1 i txt den alıyor.
            sayi2 = Convert.ToDouble(txtSayı2.Text);
            if (cmbSecim.Text=="+")
            {
                sonuc = sayi1 + sayi2;
                lblSonuc.Text =Convert.ToString( sonuc);
                txtSayıbir.Clear();
                txtSayı2.Clear();
                cmbSecim.Text = "";
                    
            }
            if (cmbSecim.Text == "-")
            {
                sonuc = sayi1 - sayi2;
                lblSonuc.Text = Convert.ToString(sonuc);
                txtSayıbir.Clear();
                txtSayı2.Clear();
                cmbSecim.Text = "";
            }
            if (cmbSecim.Text == "*")
            {
                sonuc = sayi1 * sayi2;
                lblSonuc.Text = Convert.ToString(sonuc);
                txtSayıbir.Clear();
                txtSayı2.Clear();
                cmbSecim.Text = "";
            }
            if (cmbSecim.Text == "/")
            {
                sonuc = sayi1 / sayi2;
                lblSonuc.Text = Convert.ToString(sonuc);
                txtSayıbir.Clear();
                txtSayı2.Clear();
                cmbSecim.Text = "";
            }

        }
    }
}
