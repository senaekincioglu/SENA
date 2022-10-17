using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlararasıgeçis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Giriş butonuna tıkaldığında kullanıcı adı ve şifre doğru ise form iyiye geçip renk değiştirsin
           
            string kullaniciAdi, sifre;
            kullaniciAdi = Convert.ToString(txtKullaniciadi.Text);
            sifre = Convert.ToString(txtSifre.Text);
            if(kullaniciAdi=="senaeknc"&&sifre=="1234")
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();

                Color[] renkler = new Color[8] { Color.Red, Color.Blue, Color.Black, Color.Brown,Color.Purple, Color.White, Color.Pink, Color.Yellow };
                Random rnd = new Random();
                int renk = rnd.Next(0, 7);
                frm.BackColor = renkler[renk];//2. forma geçerken ki form adı frm yazılır.
            }
            else
            {
                MessageBox.Show("Hatalı giriş ");
                txtKullaniciadi.Clear();
                txtSifre.Clear();
            }
            
        }
    }
}
