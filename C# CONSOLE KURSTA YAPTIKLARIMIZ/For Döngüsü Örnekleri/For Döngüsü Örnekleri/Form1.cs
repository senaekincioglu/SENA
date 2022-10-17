namespace For_Döngüsü_Örnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            //Göster butonuna tıklandığında sayıları tek sayıları çift sayıları  gösteren kod.

            for(int i=1;i<=50;i++)
            {
                lblSayilar.Text = lblSayilar.Text + " " + i;
                if(i%2==1)
                {
                    lblTeksayilar.Text = lblTeksayilar.Text + " " + i ;
                }
                else
                {
                    lblCiftSayilar.Text = lblCiftSayilar.Text + " " + i ;
                }
            }


        }

       
    }
}