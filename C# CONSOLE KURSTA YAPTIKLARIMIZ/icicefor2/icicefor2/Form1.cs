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
            //Klavyeden girilecek olan bir c�mleyi ilk harften ba�layarak bir harf artt�rarak alt alta ekrana yazd�ran program�n C# kodunu yaz�n�z.

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