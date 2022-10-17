namespace Tek_boyutlu_diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            int[] sayilar = new int[6];
            Random rnd = new Random();
            
            for (int i=0; i<sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0, 50);
            }
            foreach(int i in sayilar)
            {
                listBox1.Items.Add(i);
            }
            listBox1.Text = " ";
        }
    }
}