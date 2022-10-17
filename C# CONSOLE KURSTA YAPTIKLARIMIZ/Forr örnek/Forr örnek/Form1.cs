namespace Forr_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            //Göster butonuna tıklandığında başlangıç ve bitiş sayıları içinde 3 ve 5 e bölünen sayılardan kaç tane olduğunu gösteren kod.
            int baslangic = Convert.ToInt32(txtBaslangic.Text);
            int bitis = Convert.ToInt32(txtBitis.Text);
            int sayac = 0;
            for(int i=baslangic;i<=bitis;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    lstGoster.Items.Add(i.ToString());
                    sayac++;     
                }
                
            }
            MessageBox.Show("3 ve 5 e tam bölünen sayı adededi " + sayac);
        }
    }
}