using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Topla_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int sonuc = sayi1 + sayi2;
                label3.Text = "Sonuç:" + Convert.ToString(sonuc);
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show("Hata:" + x.Message);
            }
        }

        private void Cıkar_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int sonuc = sayi1 - sayi2;
                label3.Text = "Sonuç:" + Convert.ToString(sonuc);
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show("Hata:" + x.Message);
            }
        }

        private void Bol_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int sonuc = sayi1 / sayi2;
                label3.Text = "Sonuç:" + Convert.ToString(sonuc);
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show("Hata:" + x.Message);
            }
        }

        private void Carp_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int sonuc = sayi1 * sayi2;
                label3.Text = "Sonuç:" + Convert.ToString(sonuc);
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show("Hata:" + x.Message);
            }
        } 
    }
}
