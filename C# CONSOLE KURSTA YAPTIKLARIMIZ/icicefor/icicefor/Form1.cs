namespace icicefor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Butona �ift t�klad���nda yan yana 10 tane y�ld�z yazd�rs�n.
            //for (int i = 0; i <= 10; i++)
            //{
            //    label1.Text += " * ";

            //}



            //ilk sat�rda bir , sonraki sat�rda iki �eklinde her sat�rda bir art�rarak yap�lmak istenirse i� i�e d�ng� kullan�lmal�d�r.

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        label1.Text += " * ";

            //    }
            //    label1.Text += "\n";
            //}



            //Butona t�klad���nda textboxa girilen kelime say�s� kadar artmas� ve alt alta yazd�rmas�

            //for (int i = 0; i <textBox1.Text.Length; i++)
            //{
            //    for (int j = 0; j <=i; j++)
            //    {
            //        label1.Text += textBox1.Text[j];
            //    }
            //    label1.Text += "\n";




            //Klavyeden girilen de�erden ba�layarak ekran* simgesini birer azaltarak ekrana yazd�ran C# kodunu yaz�n�z.

            for (int i =textBox1.Text.Length;i>0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    label1.Text += textBox1.Text[j];
                }
                label1.Text += "\n";
            }

        }
    



        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = " ";
        }
    }
}