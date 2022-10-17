namespace While_Döngüsü_Murat_Yücedağ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Göster butonuna bastığında klavyeden girilen sayı çift ise message box olarak tek sayı girin uyarısı gelsin ve girilen çift sayıyı label a eklesin. Ama girilen sayı tekse Message box olarak Tek sayı girdiniz desin ve labela eklesin.

            int sayi;
            sayi = Convert.ToInt32(txtSayigirin.Text);
            while(sayi%2==0)
            {
                MessageBox.Show("Lütfen tek sayı giriniz");
                label2.Text=(txtSayigirin.Text);
                break;

                
            }
            while (sayi % 2 == 1)
            {
                MessageBox.Show("Tek sayı Girdiniz");
                label2.Text = txtSayigirin.Text;
                break;
            }
        }
    }
}