using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizilerDöngülerÖdev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKarebul_Click(object sender, EventArgs e)
        {
            lstSayilar.Items.Clear();   
            //Kare bul butonuna tıklandığında textboxa girilen sayı kadar tek tek karelerini
            //yazdıran program
            int i = 0;
            int sayi = Convert.ToInt32(txtGirilensayi.Text);
            
            while (i<sayi)
            {
                i++;

                lstSayilar.Items.Add(i + " sayısının karesi= " + i * i);
                
            }

            //int kare;
            //int sayi = Convert.ToInt32(txtGirilensayi.Text);
            //for (int i = 1; i <= sayi; i++)
            //{


            //    kare = i * i;
            //    lstSayilar.Items.Add(i + " sayısının karesi: " + kare);
            //}





        } 

        private void btnUcuncusayfagec_Click(object sender, EventArgs e)
        {
            Form3 tahminsayfası = new Form3();
            tahminsayfası.Show();
            this.Hide();
        }

        private void btnGecbirinci_Click(object sender, EventArgs e)
        {
            Form1 gecbirincisayfa = new Form1();
            gecbirincisayfa.Show();
            this.Hide();
        }

        private void txtGirilensayi_KeyPress(object sender, KeyPressEventArgs e)
        {
              if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8  )
            {
                e.Handled = true;
            }
        }
    }
}
