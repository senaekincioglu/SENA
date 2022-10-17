using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Ödevi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre;
            kullaniciadi = Convert.ToString(txtKullaniciadi.Text);
            sifre = Convert.ToString(txtSifre.Text);

            if(kullaniciadi=="sa"&&sifre=="as")
            {
                MessageBox.Show("Doğru giriş yaptınız");
            }
            else
            {
                MessageBox.Show("Yanlış giriş yaptınız");
            }
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
            


        }
    }
}
