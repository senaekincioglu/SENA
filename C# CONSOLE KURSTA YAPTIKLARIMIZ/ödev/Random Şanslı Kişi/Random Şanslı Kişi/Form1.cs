namespace Random_Şanslı_Kişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSanslikisi_Click(object sender, EventArgs e)
        {
            //Butona tıkladığında dizideki elemanlardan şanslı kişiyi bulan program         
            string[] isimler = { "Hüseyin", "Necla", "Öznur", "Elif", "Oğuz", "Ezgi", "Şeyma", "Beyza", "Sena" };
            Random rnd = new Random();
            //sayı yerine 0 dan isimler dizisindeki isimleri seçiyor
            int rastgele = rnd.Next(0, isimler.Length);
            //İsimler dizisindeki rastgele gelen elemanı yazdırıyor.
            //MessageBox.Show("Seçilen isim = " + isimler[rastgele]);
            lblGoster.  ForeColor = Color.Red;
            lblGoster.Text= isimler[rastgele];  
        }

        private void btnİkincisayfa_Click(object sender, EventArgs e)
        {
            Form2 beslikSistem = new Form2();
            beslikSistem.Show();
            this.Hide();
        }
    }
}