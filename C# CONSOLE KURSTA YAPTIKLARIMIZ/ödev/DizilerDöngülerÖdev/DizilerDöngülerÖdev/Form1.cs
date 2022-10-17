namespace DizilerDöngülerÖdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        private void btnListele_Click(object sender, EventArgs e)
        {
            //Listele butonuna tıklandığında 0 dan 10 a kadar olan sayıları listboxa ekleyen program
            lstListeletopla.Items.Clear();
           
            for (int i = 0; i < sayilar.Length; i++)
            {
                lstListeletopla.Items.Add(sayilar[i]);
            }            
        }

        private void txtİkincisayfagec_Click(object sender, EventArgs e)
        {
            Form2 karebul = new Form2();
            karebul.Show();
            this.Hide();
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            //Topla butonuna tıklandığında 0 dan 10 a kadar olan sayıları toplayıp message box a
            //yazdırıyor            
            int toplam = 0;
            
                foreach (int sayi in sayilar)
                {
                    toplam = toplam + sayi;
               
                }
            MessageBox.Show("Toplam sayı= " + toplam);

        }
    }
}