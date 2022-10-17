namespace icicefor2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Klavyeden girilecek olan bir cümleyi ilk harften baþlayarak bir harf arttýrarak alt alta ekrana yazdýran programýn C# kodunu yazýnýz.

            //string sayi = Convert.ToString(textBox1.Text);
            //for (int i = 0; i <sayi.Length; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        label2.Text+=sayi[j];
            //    }
            //    label2.Text+=("\n");


            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    label2.Text += textBox1.Text[j];
                }
                label2.Text += "\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = " ";
        }
    }
}