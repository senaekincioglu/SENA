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

namespace Random_Şanslı_Kişi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnUcuncusayfa_Click(object sender, EventArgs e)
        {
            Form3 Renkler = new Form3();
            Renkler.Show();
            this.Hide();
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtBeslikSistem.Text);

            if (sayi < 0 || sayi > 100)
            {
                MessageBox.Show("Girilen sayı 0 ile 100 arasında olmalıdır.");
            }

            if (sayi == 0 || sayi <= 24)
            {
                MessageBox.Show("Not değeri = 0");
            }
            else if (sayi == 25 || sayi <= 44)
            {
                MessageBox.Show("Not değeri = 1");
            }
            else if (sayi == 45 || sayi <= 54)
            {
                MessageBox.Show("Not değeri = 2");
            }
            else if (sayi == 55 || sayi <= 69)
            {
                MessageBox.Show("Not değeri = 3");
            }
            else if (sayi == 70 || sayi <= 84)
            {
                MessageBox.Show("Not değeri = 4");
            }
            else if(sayi == 85 || sayi <=100)
            {
                MessageBox.Show("Not değeri = 5");
            }

        }

        private void btnGitbirincisayfa_Click(object sender, EventArgs e)
        {
            Form1 birincisayfa = new Form1();
            birincisayfa.Show();
            this.Hide();
        }

        
    }
}
