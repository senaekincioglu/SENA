namespace While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //butona basýldýðýnda kodumuzdan label1 10 dan küçük olduðu sürece ekrana mesaj kutusu göstermesini istedik. ve Tamama bastýkça mesaj çýkýyor deðiþtirmeye fýrsat vermiyor 
            int a, b, x;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            x = a * b;
            label1.Text = x.ToString();
            while (Convert.ToInt32(label1.Text)<10)
            {
                MessageBox.Show("deneme");
                
            }
        }
    }
}