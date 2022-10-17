namespace Metot_ile_Yazılı_Ortalaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Textboxa değer girileceğindne dolayı PARAMETRELİ, bir sonuç değer döndüreceği için DEĞER DÖNDÜREN
        // METOT  
        private float OrtalamaHesaplama(float not1,float not2)
        {
           return  (not1 + not2) / 2;
              
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float sayi1 = Convert.ToInt32(txtNotbir.Text);
            float sayi2= Convert.ToInt32(txtNotiki.Text);
            lblOrtalama.Text = OrtalamaHesaplama(sayi1, sayi2).ToString();
            
        }
    }
}