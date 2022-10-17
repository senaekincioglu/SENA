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
    public partial class CarpimTablosu1 : Form
    {
        public CarpimTablosu1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    listBox2.Items.Add((i) + "x" + j + "=" + (j) * i);
                }
            }
        }
        int kacAdet = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            
            kacAdet = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= kacAdet; i++)
            {
                ListBox listBox = new ListBox();
                listBox.Top = 90;
                listBox.Left = 70 + ((i - 1) * 105);
                listBox.Width = 100;
                listBox.Name = "ListBox" + (i.ToString());
                this.Controls.Add(listBox);

                for (int j = 1; j <= 10; j++)
                {
                    listBox.Items.Add((i) + "x" + j + "=" + (j) * i);
                }

            }
            



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarpimTablosu form1 = new CarpimTablosu();
            this.Hide();
            form1.Show();
        }
    }
}
