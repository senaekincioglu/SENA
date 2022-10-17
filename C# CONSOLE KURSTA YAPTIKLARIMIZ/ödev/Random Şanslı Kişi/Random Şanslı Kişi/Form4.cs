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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Butona bastığında textboxa girilen sayı 5 den küçükse kötü büyükse mesaj boxa iyi yazdıran program.
            int girilenSayi = Convert.ToInt32(txtPuanver.Text);
            string durum = girilenSayi < 5 ? "KÖTÜ" : "İYİ";
            MessageBox.Show(durum);

        }

        private void btnGitucuncusayfa_Click(object sender, EventArgs e)
        {
            Form3 ucuncusayfa = new Form3();
            ucuncusayfa.Show();
            this.Hide();
        }
    }
}
