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
            //Butona çift týkladýðýnda yan yana 10 tane yýldýz yazdýrsýn.
            //for (int i = 0; i <= 10; i++)
            //{
            //    label1.Text += " * ";

            //}



            //ilk satýrda bir , sonraki satýrda iki þeklinde her satýrda bir artýrarak yapýlmak istenirse iç içe döngü kullanýlmalýdýr.

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        label1.Text += " * ";

            //    }
            //    label1.Text += "\n";
            //}



            //Butona týkladýðýnda textboxa girilen kelime sayýsý kadar artmasý ve alt alta yazdýrmasý

            //for (int i = 0; i <textBox1.Text.Length; i++)
            //{
            //    for (int j = 0; j <=i; j++)
            //    {
            //        label1.Text += textBox1.Text[j];
            //    }
            //    label1.Text += "\n";




            //Klavyeden girilen deðerden baþlayarak ekran* simgesini birer azaltarak ekrana yazdýran C# kodunu yazýnýz.

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