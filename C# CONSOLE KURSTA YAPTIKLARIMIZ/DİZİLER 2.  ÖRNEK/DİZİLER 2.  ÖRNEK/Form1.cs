namespace DİZİLER_2.__ÖRNEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Hesapla butonuna tıklandığında klavyeden 5 sayı girilecek alınan sayıları diziye atılacak ve dizi içerisindeki en büyük değer bulunup ekrana yazdırılan program.
            int[] sayilar = new int[5];
            for(int i =0;i<5;i++)
            {
                lblenbuyuksayi.Text = txtSayibir.Text;
                lblenbuyuksayi.Text = txtSayiiki.Text;
                lblenbuyuksayi.Text = txtSayiüc.Text;
                lblenbuyuksayi.Text = txtsayidort.Text;
                lblenbuyuksayi.Text = txtsayibes.Text;
            }

        }
    }
}