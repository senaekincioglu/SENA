using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Şanslı_Kişi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtRenk.Text = txtRenk.Text.ToUpper();
            txtRenk.SelectionStart = txtRenk.Text.Length;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            switch(txtRenk.Text)
            {
                case "KIRMIZI":btnRenk.BackColor = Color.Red; break;
                case "BEYAZ":btnRenk.BackColor = Color.White; break;
                case "SARI": btnRenk.BackColor = Color.Yellow; break;
                case "TURUNCU": btnRenk.BackColor = Color.Orange; break;
                case "PEMBE": btnRenk.BackColor = Color.Pink; break;
                case "YEŞİL": btnRenk.BackColor = Color.Green; break;
                case "MAVİ": btnRenk.BackColor = Color.Blue; break;
                case "MOR": btnRenk.BackColor = Color.Purple; break;
                case "KAHVERENGİ": btnRenk.BackColor = Color.Brown; break;
                case "ALTIN": btnRenk.BackColor = Color.Gold; break;
                case "HAKİ": btnRenk.BackColor = Color.Khaki; break;
                case "LACİVERT": btnRenk.BackColor = Color.Navy; break;
                case "TURKUAZ": btnRenk.BackColor = Color.Turquoise; break;
                
                default : btnRenk.BackColor = Color.Black; break;
            }
        }

        private void btnDorduncusayfa_Click(object sender, EventArgs e)
        {
            Form4 terrnary = new Form4();
            terrnary.Show();
            this.Hide();
        }

        private void btnGitikincisayfa_Click(object sender, EventArgs e)
        {
            Form2 ikincisayfa = new Form2();
            ikincisayfa.Show();
            this.Hide();
        }
    }
}
