using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DizilerDöngülerÖdev
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            // klavyeden girdiğin sayıyı kaç kez de bulduğunu yazan program

            int sayi, sayac = 0, a;
            sayi = Convert.ToInt32(txtSayi.Text);
            //scope
            do
            {

                Random rnd = new Random();
                //1 ile 1000 arasında kaçıncıda bulacak 
                a = rnd.Next(0, 1000);

                lstSayilar.Items.Add(a);
                sayac++;

                if (a == sayi)
                {
                    MessageBox.Show("Sistem girmiş olduğunuz sayıyı " + sayac + " kerede bulmuştur");
                    break;
                }

            }
            while (a != sayi);
            

            


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstSayilar.Items.Clear();
        }
    }
}

