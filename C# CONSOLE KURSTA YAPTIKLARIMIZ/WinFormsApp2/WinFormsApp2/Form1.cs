namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            //G�ster butonuna t�kland���nda label2 ye 1 den 10 a kadar y�ld�zlar� yazd�ran, label 3 e textboxtaki kelime kadar ka� harf varsa o kadar artan� yazd�ran kod.
            //�zerine ekleyerek g�sterece�i i�in += yap�l�r.
            //Her seferinde a�a�� inmesini istedi�imn i�in \n parametresi kullan�l�r.
            //for (int i = 1; i<=10; i++)
            //{
            //   for(int j = 0; j<=i; j++)
            //    {
            //        label2.Text += "*";
            //    }
            //    label2.Text += "\n";
            //}


            for (int i = 1; i <=txtMetin.Text.Length; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    label3.Text += txtMetin.Text[j];
                }
                label3.Text += "\n";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}