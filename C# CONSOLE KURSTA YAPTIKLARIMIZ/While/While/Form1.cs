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
            //butona bas�ld���nda kodumuzdan label1 10 dan k���k oldu�u s�rece ekrana mesaj kutusu g�stermesini istedik. ve Tamama bast�k�a mesaj ��k�yor de�i�tirmeye f�rsat vermiyor 
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