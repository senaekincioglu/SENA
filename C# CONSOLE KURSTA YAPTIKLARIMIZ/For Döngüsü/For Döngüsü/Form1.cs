namespace For_Döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            //Butona tıklandığında kullanıcının girdiği isim ve adet kadar listboxa yazdıran kod.
            
            int adet = Convert.ToInt32(txtAdet.Text);
            for (int i = 1; i <= adet; i++) 
            {
                lstAdadet.Items.Add(txtAd.Text);
            }
           
        }
    }
}