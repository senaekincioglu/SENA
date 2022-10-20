using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Karsılastır_click(object sender, EventArgs e)
        {
            string s1, s2;
            s1 = textBox1.Text;
            s2 = textBox2.Text;

            int result = string.Compare(s1, s2, true);
            if (result < 0)
                label3.Text = "Birinci string ikinci stringden büyük.";
            else if (result > 0)
                label3.Text = "Birinci string ikinci stringden küçük.";
            else
                label3.Text = "İki string eşit";
                label3.Visible = true;
        }
    }
}
