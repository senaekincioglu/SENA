namespace For_Döngüsü_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            //Göster butonuna basıldığında başlangıç ve bitiş değerini kullanıcının verdiği sayıları ListBox’ ekleyin.

            int baslangic = Convert.ToInt32(txtBaslangic.Text);
            int bitis = Convert.ToInt32(txtBitis.Text);
            for(int i=baslangic;i<=bitis;i++)
            {
                lstbaslangicbitis.Items.Add(i.ToString());
            }

        }
    }
}