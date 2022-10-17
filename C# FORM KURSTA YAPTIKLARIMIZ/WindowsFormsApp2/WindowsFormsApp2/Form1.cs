using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Merhaba");
            //Kaydet tuşuna bastığında textboxa girilenleri labela ekleyen program.
            lblsıfır.Text = Convert.ToString(txtAd.Text);//label a yazdır girilen tetxboxtaki değeri
            lblsıfır2.Text = Convert.ToString(txtSoyad.Text);//label a yazdır girilen tetxboxtaki değeri
            //btnKaydet.Text = Convert.ToString(txtAd.Text + txtSoyad.Text);
            lblSehir.Text = cmbSehir.Text;
            



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
