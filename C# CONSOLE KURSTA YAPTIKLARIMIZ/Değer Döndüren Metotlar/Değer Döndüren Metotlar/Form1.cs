namespace Değer_Döndüren_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Parametre almayan Değer Döndüren metotlar
        private string Mesaj()
        {
            return "Metod Çağırıldı";
        }
        //Parametre alan Değer Döndüren Metotlar
        private int Topla(int a,int b)
        {
            return a + b;   
        }
        private void btnParametresizMetod_Click(object sender, EventArgs e)
        {
            lblMetoduYazdir.Text = Mesaj();    
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtBirincisayi.Text);
            int sayi2= Convert.ToInt32(txtİkincisayi.Text);
            lblSonuc.Text = Topla(sayi1, sayi2).ToString();
        }
    }
}