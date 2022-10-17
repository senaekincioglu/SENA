namespace Murat_Yücedağ_forea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Butona tıklandığında oluşturduğun dizide 2 ye tam bölünen elemanları listboxa ekleyen kod.
            int[] rakamlar = { 2, 5, 10, 80, 15, 6 };
            foreach(int i in rakamlar)
            {
                if(i%2==0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}