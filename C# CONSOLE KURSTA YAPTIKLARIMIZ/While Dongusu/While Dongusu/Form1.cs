namespace While_Dongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //100 ile 200 aras�ndaki tek say�lar�n toplam�n� bulan while d�ng�s�.

            int sayi = 0;
            int toplam = 100;
            while(sayi<=200)
            {
                if(sayi%2==1)
                {
                    toplam += sayi;
                    sayi++;
                    break;


                }
                MessageBox.Show("Tek say�lar�n toplam�" + toplam.ToString());
            }

        }
    }
}