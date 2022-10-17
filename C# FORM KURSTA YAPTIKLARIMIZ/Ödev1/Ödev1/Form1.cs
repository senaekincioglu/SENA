using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1
{
    public partial class Form1 : Form
    {
        public string secim = " ";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnl.Visible=false;  
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            secim = "Kare";
            //BUNLARI İF İLE YAP
            lblKarealansonuc.Visible = true;
            lblKarealan.Visible = true;
            lblKareCevre.Visible = true;
            txtKenarkare.Visible = true;
            lbl_Kare.Visible = true;

            lbl_Dikdortgen1.Visible = false;
            lbl_Dikdortgen2.Visible = false;
            lbl_Ucgentaban.Visible = false;
            lbl_Ucgenyukseklik.Visible = false;
            lbl_Yaricapdaire.Visible = false;

            txtKDikdorgenkenar1.Visible = false;
            txtKDikdorgenkenar2.Visible = false;
            txtUcgentaban.Visible = false;
            txtUcgenyukseklik.Visible = false;
            txtDaireYaricap.Visible = false;
            lblDikdortgenalan.Visible = false;
            lblDikdörtgencevre.Visible = false;
            lblUcgenAlan.Visible = false;
            lblUcgencevre.Visible = false;
            lblDairealan.Visible = false;
            lblDaireCevre.Visible = false;

            lblDikdorgenalansonuc.Visible = false;
            lblDikdortgencevresonuc.Visible = false;
            lblUcgenalansonuc.Visible = false;
            lblUcgencevresonuc.Visible = false;
            lblDairealansonuc.Visible = false;
            lblDairecevresonuc.Visible = false;

            pnl.Visible = true;


        }

        private void btnDikdortgen_Click(object sender, EventArgs e)
        {
            secim = "Dikdörtgen";

            lbl_Dikdortgen1.Visible = true;
            lbl_Dikdortgen2.Visible = true;
            txtKDikdorgenkenar1.Visible = true;
            txtKDikdorgenkenar2.Visible = true;
            lblDikdortgenalan.Visible = true;
            lblDikdörtgencevre.Visible = true;
            lblDikdorgenalansonuc.Visible = true;
            lblDikdortgencevresonuc.Visible = true;

            lbl_Kare.Visible = false;
            
            lbl_Ucgentaban.Visible = false;
            lbl_Ucgenyukseklik.Visible = false;
            lbl_Yaricapdaire.Visible = false;

            txtKenarkare.Visible = false;
            txtUcgentaban.Visible = false;
            txtUcgenyukseklik.Visible = false;
            txtDaireYaricap.Visible = false;

            lblKarealan.Visible = false;
            lblKareCevre.Visible = false;
            
            lblUcgencevre.Visible = false;
            lblUcgenAlan.Visible = false;
            lblDairealan.Visible = false;
            lblDaireCevre.Visible = false;

            lblKarealansonuc.Visible = false;
            lblUcgenalansonuc.Visible = false;
            lblUcgencevresonuc.Visible = false;
            lblDairealansonuc.Visible = false;
            lblDairecevresonuc.Visible = false;

            pnl.Visible = true;
        }

        private void btnUcgen_Click(object sender, EventArgs e)
        {
            secim = "Üçgen";

            lbl_Ucgentaban.Visible = true;
            lbl_Ucgenyukseklik.Visible = true;
            lblUcgenAlan.Visible = true;
            lblUcgencevre.Visible = true;
            lblUcgenalansonuc.Visible = true;
            lblUcgencevresonuc.Visible = true;
            txtUcgentaban.Visible = true;
            txtUcgenyukseklik.Visible = true;

            lbl_Kare.Visible = false;
            lbl_Dikdortgen1.Visible = false;
            lbl_Dikdortgen2.Visible = false;
            
            lbl_Yaricapdaire.Visible = false;

            txtKenarkare.Visible = false;
            txtKDikdorgenkenar1.Visible = false;
            txtKDikdorgenkenar2.Visible = false;
           
            txtDaireYaricap.Visible = false;

            lblKareCevre.Visible = false;
            lblKarealan.Visible = false;
            lblDikdörtgencevre.Visible = false;

            lblDikdortgenalan.Visible = false;
            lblDairealan.Visible = false;
            lblDaireCevre.Visible = false;

            lblKarealansonuc.Visible = false;
            lblDikdorgenalansonuc.Visible = false;
            lblDairealansonuc.Visible = false;
            lblDairecevresonuc.Visible = false;

            pnl.Visible = true;
        }

        private void btnDaire_Click(object sender, EventArgs e)
        {
            secim = "Daire";

            lbl_Yaricapdaire.Visible = true;
            lblDairealan.Visible = true;
            lblDaireCevre.Visible = true;
            lblDairealansonuc.Visible = true;
            lblDairecevresonuc.Visible = true;
            txtDaireYaricap.Visible = true;

            lbl_Kare.Visible = false;
            lbl_Dikdortgen1.Visible = false;
            lbl_Dikdortgen2.Visible = false;
            lbl_Ucgentaban.Visible = false;
            lbl_Ucgenyukseklik.Visible = false;

            txtKenarkare.Visible = false;
            txtKDikdorgenkenar1.Visible = false;
            txtKDikdorgenkenar2.Visible = false;
            txtUcgentaban.Visible = false;
            txtUcgenyukseklik.Visible = false;
            
            lblKarealan.Visible = false;
            lblKareCevre.Visible = false;
            lblDikdortgenalan.Visible = false;
            lblDikdörtgencevre.Visible = false;
            lblUcgenAlan.Visible = false;
            lblUcgencevre.Visible = false;
         
            lblKarealansonuc.Visible = false;
            lblKarecevresonuc.Visible = false;
            lblDikdorgenalansonuc.Visible = false;
            lblDikdortgencevresonuc.Visible = false;
            lblUcgenalansonuc.Visible = false;
            lblUcgencevresonuc.Visible = false;
      
            pnl.Visible = true;

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double kenar, kenar2, taban, yukseklik, yaricap,sonuc=0,alan,cevre;

            switch(secim)
            {
                case "Kare":kenar = Convert.ToDouble(txtKenarkare.Text);
                    alan = kenar * kenar;
                    cevre = 4 * kenar;
                    lblKarealansonuc.Text = Convert.ToString(alan);
                    lblKarecevresonuc.Text = Convert.ToString(cevre);
                    break;
                case "Dikdörtgen":kenar = Convert.ToDouble(txtKDikdorgenkenar1.Text);
                    kenar2 = Convert.ToDouble(txtKDikdorgenkenar2.Text);
                    alan = kenar * kenar2;
                    cevre = 2 * (kenar + kenar2);
                    lblDikdorgenalansonuc.Text = Convert.ToString(alan);
                    lblDikdortgencevresonuc.Text = Convert.ToString(cevre);
                    break;
                case "Üçgen":taban = Convert.ToDouble(txtUcgentaban.Text);
                    yukseklik = Convert.ToDouble(txtUcgenyukseklik.Text);
                    alan = (taban * yukseklik) / 2;
                    lblUcgenalansonuc.Text = Convert.ToString(alan);
                    
                    
                    break;
                case "Daire": yaricap=Convert.ToDouble(txtDaireYaricap.Text);
                    alan = Math.PI * (yaricap * yaricap);
                    cevre = 2 * Math.PI * yaricap;
                    lblDairealansonuc.Text = Convert.ToString(alan);
                    lblUcgencevresonuc.Text = Convert.ToString(cevre);
                    break;
            }
        }

       
    }
}
