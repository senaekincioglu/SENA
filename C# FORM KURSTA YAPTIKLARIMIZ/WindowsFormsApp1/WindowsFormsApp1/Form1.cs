using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz");//form açıldığında bilgi versin.
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //butona tıklandığında mesaj versin.
            MessageBox.Show("Merhaba");
            int sayi1 = 5, sayi2 = 10, toplam = 0 ;
            toplam = sayi1 + sayi2;
            MessageBox.Show("Toplam= " + toplam);
            
        }
    }
}
