using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İki_tarih_arası_gün_hesaplama
{
    public partial class Form1 : Form
    {
        TimeSpan gunfarki;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            //datetime tarih saat. 
            //timespan zaman aralığı 
            DateTime baslangic = Convert.ToDateTime(dpBaslangic.Text);
            DateTime bitis = Convert.ToDateTime(dpBitis.Text);
            TimeSpan gunfarki = bitis - baslangic;
            txtGunfarki.Text = gunfarki.TotalDays.ToString();
        }
    }
}
