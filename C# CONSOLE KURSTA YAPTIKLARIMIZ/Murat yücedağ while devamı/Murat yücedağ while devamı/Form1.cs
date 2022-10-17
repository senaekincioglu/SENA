namespace Murat_yücedağ_while_devamı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Butona tıklandığında textboxa girilen sayının faktöriyelini hesaplayıp label2 ye yazan program.
            int sayi, faktoryel=1;
            sayi = Convert.ToInt32(txtSayigirin.Text);
            while(sayi>1)
            {
                faktoryel = sayi * faktoryel;
                sayi--;
                label2.Text = ("Klavyeden girilen sayının faktöriyeli= " +  faktoryel);
            }
            //5*1=5
            //5*4=20
            //20*3=60
            //60*2=120 gibi...

        }
    }
}