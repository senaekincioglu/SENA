using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_Kayıt_Formu_2
{
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }


        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    string tc;
        //    tc = textBox1.Text;

        //    if (tc.Length == 11)

        //    {
        //        OkulKayıtFormu.Items.Add(textBox1.Text);

        //    }

        //    else
        //    {
        //        MessageBox.Show("Tc no boş olamaz ve 11 haneli olmalı ");
        //    }



        //    string ad, soyad;
        //    ad = textBox2.Text;
        //    soyad = textBox3.Text;

        //    if (string.IsNullOrEmpty(ad) && string.IsNullOrEmpty(soyad)) 

        //    {
        //        MessageBox.Show("Lütfen ad ve Soyad Giriniz");

        //    }

        //    else
        //    {
        //        OkulKayıtFormu.Items.Add(textBox2.Text + "  "  + textBox3.Text);
        //    }


        //    OkulKayıtFormu.Items.Add(dateTimePicker1.Text);

        //    string cinsiyet = comboBox1.Text;
        //    if (string.IsNullOrEmpty(cinsiyet)) 

        //    {              

        //        MessageBox.Show("Lütfen Cinsiyet Seçin");
        //    }

        //    else
        //    {
        //        OkulKayıtFormu.Items.Add(comboBox1.Text);
        //    }



        //    string okul;
        //    okul = textBox4.Text;

        //    if(string.IsNullOrEmpty(okul))

        //    {
        //        MessageBox.Show("Lütfen Okul bilgisi girin");
        //    }

        //    else
        //    {
        //        OkulKayıtFormu.Items.Add(textBox4.Text);
        //    }







        //}

        //private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //   if( char.IsDigit(e.KeyChar))

        //    {

        //        e.Handled = true;
        //    }






        //private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if(char.IsDigit(e.KeyChar))

        //    {
        //        e.Handled = true;
        //    }
        //}

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;

            string tc = txtTc.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string dogumTarihi = dpDogumTarihi.Text;
            string cinsiyet = cmbCinsiyet.Text;
            string okul = txtOkul.Text;

            if (string.IsNullOrEmpty(tc) ||
                string.IsNullOrEmpty(ad) ||
                string.IsNullOrEmpty(soyad) ||
                string.IsNullOrEmpty(dogumTarihi) ||
                string.IsNullOrEmpty(cinsiyet) ||
                string.IsNullOrEmpty(okul))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");

            }
            //else içinde if kullanıldı ama direkt else if de olur
            else
            {
                if (tc.Length != 11)
                {
                    MessageBox.Show("TC 11 haneli olmalıdır");
                }
                else
                {
                    lstBilgiler.Items.Clear();
                    lstBilgiler.Items.Add(tc);
                    lstBilgiler.Items.Add(ad);
                    lstBilgiler.Items.Add(soyad);
                    lstBilgiler.Items.Add(dogumTarihi);
                    lstBilgiler.Items.Add(cinsiyet);
                    lstBilgiler.Items.Add(okul);


                }
            }
            MessageBox.Show("Teşekkürler");
            this.BackColor = Color.Blue;
        }

        private void TxtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Bu alan harflerden oluşmalı");
                e.Handled = true;
            }
        }

    }
}
