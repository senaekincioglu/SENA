namespace swicrandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            //Kullan�c� taraf�ndan girilen say�n�n a�a��daki �nergelere g�re hesab�n� yapan program.
            //say�<3 ise say�*5
            //say�>3 && ve say�<9 ise say�*3
            //say�>=9 && say� %2==0 ise say�*10
            //say�%2==1 ise say� 

            int sayi = Convert.ToInt32(textBox1.Text);
            int sonuc = sayi < 3 ? sayi * 5 : (sayi > 3 && sayi < 9 ? sayi * 3 : (sayi >= 9 && sayi % 2 == 0) ? sayi * 10 : sayi % 2 == 1 ? sayi : -1);
            MessageBox.Show("Sonuc= "+ sonuc);

        }
    }
}