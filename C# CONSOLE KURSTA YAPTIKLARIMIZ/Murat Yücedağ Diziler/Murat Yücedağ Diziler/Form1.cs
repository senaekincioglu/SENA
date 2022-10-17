using System.Reflection.Metadata;

namespace Murat_Yücedağ_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Göster butonuna tıklandığında 3 şehri klavyeden girip listeleten program.
            //klavyeden girileceği için format new ile olur ve kaç şehir girilecekse o yazılır yani eleman sayısı.
            
            
            string[] sehirler = new string[3];
            for(int i=0;i<3;i++)//0 1 2 olarak 3 şehir yazılır.
            {
                //sehirler[i] = label1.Text;                               
                listBox1.Items.Add(sehirler[i]);               
            }

        }
    }
}