using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Fibonacci : Form
    {
        int a = 1, b = 0, c = 0;
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a=1;
            int b = 0;
            int c = 0;
            int verilensayi = 0;
            verilensayi= Convert.ToInt16(textBox1.Text);
            for (int i = 0; i < verilensayi; i++)
            {
                c = a + b;
                a = b;
                b = c;
                listBox2.Items.Add(c);
            }
                
        }

        public void Fibonacci_Hesapla()
        {

            for (int i = 0; i < 46; i++)
            {
                c = a + b;
                a = b;
                b = c;
                listBox1.Items.Add(c);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Fibonacci_Hesapla();
        }
    }
}
