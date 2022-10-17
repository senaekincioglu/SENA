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
            //Kullanýcý tarafýndan girilen sayýnýn aþaðýdaki önergelere göre hesabýný yapan program.
            //sayý<3 ise sayý*5
            //sayý>3 && ve sayý<9 ise sayý*3
            //sayý>=9 && sayý %2==0 ise sayý*10
            //sayý%2==1 ise sayý 

            int sayi = Convert.ToInt32(textBox1.Text);
            int sonuc = sayi < 3 ? sayi * 5 : (sayi > 3 && sayi < 9 ? sayi * 3 : (sayi >= 9 && sayi % 2 == 0) ? sayi * 10 : sayi % 2 == 1 ? sayi : -1);
            MessageBox.Show("Sonuc= "+ sonuc);

        }
    }
}