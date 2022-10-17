namespace Metot_ile_Dikdörtgen_Alan_Hesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //textboxa sayı girileceği için PARAMETRELİ, sonuç değer vereceği için DEĞER DÖNDÜREN   
        private double AlanHesabi(double a, double b)
        {
            return a * b;
        }
        private double CevreHesabi(double a, double b)
        {
            return 2 * (a + b);
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Hesapla butonuna tıklandığında dikdörtgenin alan ve çevresini hesaplayan program.
            double kisakenar=Convert.ToDouble(txtKisakenar.Text);    
            double uzunkenar=Convert.ToDouble(txtUzunkenar.Text);
            lblAlan.Text = AlanHesabi(kisakenar, uzunkenar).ToString();
            lblCevre.Text = CevreHesabi(kisakenar, uzunkenar).ToString();
        }
    }
}