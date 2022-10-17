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
            //Göster butonuna týklandýðýnda label2 ye 1 den 10 a kadar yýldýzlarý yazdýran, label 3 e textboxtaki kelime kadar kaç harf varsa o kadar artaný yazdýran kod.
            //üzerine ekleyerek göstereceði için += yapýlýr.
            //Her seferinde aþaðý inmesini istediðimn için \n parametresi kullanýlýr.
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