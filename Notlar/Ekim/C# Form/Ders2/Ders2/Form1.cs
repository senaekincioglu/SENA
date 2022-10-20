using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            int kısa, uzun;

            kısa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);
            int alan = (uzun*kısa);
            int cevre = (kısa * 2) + (uzun * 2);
            label3.Text = "Çevresi:" + cevre;
            label4.Text = "Alanı:" + alan;
            label3.Visible = true;
            label4.Visible = true;
        }

    }
}
