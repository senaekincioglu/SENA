namespace For_Üst_Örnekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            //Göster butonuna basıldığında kullanıcının girdiği başlangıç ve bitiş değeri kadar listboxa yazdıran kod.
            int baslangic = Convert.ToInt32(txtBaslangic);
            int bitis = Convert.ToInt32(txtBitis.Text);
            for(int i=baslangic;i<=bitis;i++)
            {
                lstGoster.Items.Add(i.ToString());
            }
        }
    }
}