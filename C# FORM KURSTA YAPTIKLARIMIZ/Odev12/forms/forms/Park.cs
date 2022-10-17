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
    public partial class Park : Form
    {
        public Park()
        {
            InitializeComponent();
        }
        Double kalinanSure, saatUcreti,toplamTutar=0;
        private void button3_Click(object sender, EventArgs e)
        {
            saatUcreti = 5;
            kalinanSure = Convert.ToInt32(comboBox1.Text);
            for (int i = 0; i < kalinanSure; i++)
            {
                saatUcreti=saatUcreti*1.2;
            }
            if (kalinanSure>=8)
            {
                saatUcreti = 20;
            }
            toplamTutar += saatUcreti;
            label3.Text = toplamTutar.ToString()+ " TL";
            listBox3.Items.Add($"{listBox3.Items.Count + 1}.Araba ==> Kalınan Süre: {kalinanSure} saat Toplam Ücret: {saatUcreti} TL");
        }
    }
}
