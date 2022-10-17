namespace metot_Örnekleriiii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Sonuç döndüren bir metot kullanarak dikdörtgenin alanını hesaplayınız
        private double alan(int a, int b)
        {
            return a * b;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            label3.Text = alan(sayi1, sayi2).ToString();
        }
    }
}