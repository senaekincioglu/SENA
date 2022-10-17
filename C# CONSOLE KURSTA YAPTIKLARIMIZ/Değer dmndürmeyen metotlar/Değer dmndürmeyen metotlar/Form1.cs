namespace Değer_dmndürmeyen_metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Parametre almayan değer döndürmeyen metot
        private void MesajYaz()
        {
            MessageBox.Show("Merhaba Kullanıcı");
        }

        //Parametre alan değer döndürmeyen metot yani dışardan bi değer girilip yazılacak
        private void MesajKutusu(string baslik, string mesaj)
        {
            MessageBox.Show(mesaj, baslik);
        }
        private void btnParametrealmayan_Click(object sender, EventArgs e)
        {
            MesajYaz();
        }

        private void btnParametrealan_Click(object sender, EventArgs e)
        {
            MesajKutusu(txtBaslik.Text, txtMesaj.Text);
        }
    }
}