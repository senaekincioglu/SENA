namespace Metot_Örnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Topla(int a,int b)
        {
            return a + b;
        }
        private int Cıkar(int a,int b)
        {
            return a - b;
        }
        private int carp(int a, int b)
        {
            return a * b;
        }
        private int bol(int a, int b)
        {
            return a / b;
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtBirincisayi.Text);
            int sayi2 = Convert.ToInt32(txtİkincisayi.Text);
            double sonuc;
            if(rdbtnTopla.Checked)
            {
                
               lblSonuc.Text= "= "+ Topla(sayi1,sayi2);                              
            }
            else if(rdbtnCikar.Checked)
            {
                lblSonuc.Text = "= " + Cıkar(sayi1 , sayi2);
            }
            else if(rdbtnCarp.Checked)
            {
                lblSonuc.Text = "= " + carp(sayi1, sayi2);
            }
            else
            {
                lblSonuc.Text = "= " + bol(sayi1, sayi2);
            }
        }
    }
}