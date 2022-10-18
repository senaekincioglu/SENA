using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_2
{
    public partial class hesapMakinesi : Form
    {
        //üçlü veya 4 lü sayı olarak yapamadım 
        double sayi1, sayi2;
        string islem;
        public hesapMakinesi()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "1";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "0";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "9";
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            lblEkran.Text = lblEkran.Text.Remove(lblEkran.Text.Length - 1);
            //sil tuşuna basınca en sonunda hata vermemesi için lblekrana 0 yazdı.
            if(lblEkran.Text=="")
            {
                lblEkran.Text = " ";
            }
        }

        

        private void Btnartı_Click(object sender, EventArgs e)
        {
            
            //sayi1 double olduğu için double a çevirdi.
            sayi1 = Convert.ToDouble(lblEkran.Text);
            //işlemin ne olduğunu yazıyor.
            islem = "+";
            //lblhafızadaki değere yazsın lblekrandaki değeri + koyarak.
            lblhafiza.Text=lblEkran.Text +  "+";
            lblEkran.Text = "";
        }

        private void Btnesittir_Click(object sender, EventArgs e)
        {
            
            sayi2 = Convert.ToDouble(lblEkran.Text);
            if(islem=="+")
            {
                lblEkran.Text = Convert.ToString(sayi1 + sayi2);
                lblhafiza.Text = "";
            }
            if (islem == "-")
            {
                lblEkran.Text = Convert.ToString(sayi1 - sayi2);
                lblhafiza.Text = "";
            }
            if (islem == "*")
            {
                lblEkran.Text = Convert.ToString(sayi1 * sayi2);
                lblhafiza.Text = "";
            }
            if (islem == "/")
            {
                lblEkran.Text = Convert.ToString(sayi1 / sayi2);
                lblhafiza.Text = "";
            }

        }

        private void Btneksi_Click(object sender, EventArgs e)
        {
            //sayi1 double olduğu için double a çevirdi.
            sayi1 = Convert.ToDouble(lblEkran.Text);
            //işlemin ne olduğunu yazıyor.
            islem = "-";
            //lblhafızadaki değere yazsın lblekrandaki değeri - koyarak.
            lblhafiza.Text = lblEkran.Text + "-";
            //eksiye basınca labelhafızaya yazdırdığı için ekranı boş bırakıyor sayı ekranda kalmıyor 
            lblEkran.Text = "";
        }

        private void Btncarpi_Click(object sender, EventArgs e)
        {
            //sayi1 double olduğu için double a çevirdi.
            sayi1 = Convert.ToDouble(lblEkran.Text);
            //işlemin ne olduğunu yazıyor.
            islem = "*";
            //lblhafızadaki değere yazsın lblekrandaki değeri * koyarak.
            lblhafiza.Text = lblEkran.Text + "*";
            lblEkran.Text = "";
        }

        private void Btnbolü_Click(object sender, EventArgs e)
        {
            //sayi1 double olduğu için double a çevirdi.
            sayi1 = Convert.ToDouble(lblEkran.Text);
            //işlemin ne olduğunu yazıyor.
            islem = "/";
            //lblhafızadaki değere yazsın lblekrandaki değeri * koyarak.
            lblhafiza.Text = lblEkran.Text + "/";
            lblEkran.Text = "";
        }

        private void Btnvirgul_Click(object sender, EventArgs e)
        {
            //contains içermek demek
            //virgüle basınca virgül içermiyorsa virgün yazsın
            if (!lblEkran.Text.Contains(","))
            {
                lblEkran.Text += ",";
            }
        }

        private void LblEkran_Click(object sender, EventArgs e)
        {

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            lblEkran.Text = "";
        }
    }
}
