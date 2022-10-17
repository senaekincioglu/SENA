namespace METOT_ÖRNEĞİ__kombinasyon_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int faktoriyel(int f)
        {
            int sonuc = 1;
            //1 den n e akadar olan sayıların çarpımı olduğu için bi dönbgü oluşturulur FOR DÖNGÜSÜ.
            for(int i=1;i<=f;i++)
            {
                sonuc=sonuc*i;  
            }
            return sonuc;   
        }
        //Kombinasyon Hesaplama bir sonuç olduğu için DEĞER DÖNDÜREN ve bir sayı girileceği için PARAMETRELİ
        //METOT KULLANILIR!!!
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN.Text);
            int r = Convert.ToInt32(txtR.Text);
            int fakn, fakr, faknr,kombinasyon;
            fakn = faktoriyel(n);
            faknr = faktoriyel(n - r);
            fakr = faktoriyel(r);
            kombinasyon = fakn / (faknr * fakr);
            lblSonuc.Text = "C(" + n + "," + r + ")=" + kombinasyon;

        }
    }
}