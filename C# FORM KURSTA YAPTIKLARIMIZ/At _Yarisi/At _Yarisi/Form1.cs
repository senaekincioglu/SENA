using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At__Yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik;
        Random rastgele = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(12, 49);
            pictureBox4.Location = new Point(12, 177);
            pictureBox2.Location = new Point(12, 319);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox4.Width;
            int ucuncuatingenisligi = pictureBox2.Width;
            pictureBox1.Left += rastgele.Next(5, 16);
            pictureBox4.Left += rastgele.Next(5, 16);
            pictureBox2.Left += rastgele.Next(5, 16);
            int bitisuzakligi = label1.Left;
            if (birinciatingenisligi + pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("1.AT KAZANDI");
            }
            if (ucuncuatingenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("3.AT KAZANDI");
            }
            if (ikinciatingenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("2.AT KAZANDI");
            }       }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            birinciatsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklik = pictureBox4.Left;
            ucuncuatsolauzaklik = pictureBox2.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
