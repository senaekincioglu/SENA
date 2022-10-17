namespace For_Örnekleri_Üst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            //Göster tuşuna bastığında kullanıcının girdiği başlangıç ve bitiş değerleri arasındaki çift sayıları listboxa yazdıran kod.
            int baslangic = Convert.ToInt32(txtBaslangic.Text);
            int bitis = Convert.ToInt32(txtBitis.Text);
            for(int i=baslangic;i<=bitis;i++)
            {
                if(i%2==0)
                {
                    lstYazdır.Items.Add(i.ToString());
                }
            }
        }

        private void btnBaslabitir_Click(object sender, EventArgs e)
        {
            //Göster tuşuna bastığında kullanıcının girdiği başlangıç ve bitiş değeri arasındaki sayılar içinde 3 e ve 5 e bölünen sayıları listboxa yazdıran kod.
            int baslangicc = Convert.ToInt32(txtBasla.Text);
            int bitir = Convert.ToInt32(txtBitir.Text);
            for(int i=baslangicc;i<=bitir;i++)
            {
                if(i%3==0 && i %5==0)
                {
                    lstEkle.Items.Add(i.ToString());
                }
            }
        }
    }
}