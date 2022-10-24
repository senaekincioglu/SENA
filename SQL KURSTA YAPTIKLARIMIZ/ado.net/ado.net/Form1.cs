using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//bu yazıldı
using System.Data.SqlClient;

namespace ado.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //bu yazıldı. UZAKTAN İÇİN BU YANİ KURSTAKİ BU.
        SqlConnection baglanti = new SqlConnection("Data source = .; initial catalog =Northwind;user = sa" +
            ";password=1234");
        //KENDİ PC DE ÇALIŞMAK İÇİN
        // SqlConnection baglantı = new SqlConnection("Data Source=.;Initial Catalog=NORTHWND;Integrated Security=True")

        void eklem() {
            //SQL DE YAZDIĞIN ÇEKTİĞİN TABLO
            SqlDataAdapter adp = new SqlDataAdapter("select * from Products", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            //İD LERİ ENGELLE(İSTEDİĞİN KOLONLARI)
            dataGridView1.Columns["ProductId"].Visible = false;
            dataGridView1.Columns["SupplierId"].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            eklem();    
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi = txtUrunadi.Text;
            decimal fiyat = nmrcFiyat.Value;
            decimal stok = nmrcFiyat.Value;


            SqlCommand komut = new SqlCommand();//ekler
            komut.CommandText = String.Format("insert into Products(ProductName,UnitPrice,UnitsInStock)values('{0}','{1}','{2}')", adi, fiyat, stok);  //ekler);
            komut.Connection = baglanti;
            baglanti.Open();
            int eklenti= komut.ExecuteNonQuery();
            baglanti.Close();
            if (eklenti>0)
            {
                MessageBox.Show("eklenmiştir");
                eklem();
            }
            else
            {
                MessageBox.Show("hata oluştu");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            //seçtiğin hücrenin ekleyeceğin kısma gelmesini istiyorsan yapılır.
            txtUrunadi.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            txtUrunadi.Tag = dataGridView1.CurrentRow.Cells["ProductID"].Value;
            nmrcFiyat.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["UnitPrice"].Value);
            nmrcStok.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["UnitsInStock"].Value);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string adi = txtUrunadi.Text;
           


            SqlCommand komut = new SqlCommand();//ekler
            komut.CommandText = String.Format("update Products set ProductName='{0}',UnitPrice={1},UnitsInStock={2} where ProductID={3} ", txtUrunadi.Text, nmrcFiyat.Value, nmrcStok.Value, txtUrunadi.Tag);
            komut.Connection = baglanti;
            baglanti.Open();
            int eklenti = komut.ExecuteNonQuery();
            baglanti.Close();
            if (eklenti > 0)
            {
                MessageBox.Show("güncellenmiştir");
                eklem();

            }
            else
            {
                MessageBox.Show("hata oluştu");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string adi = txtUrunadi.Text;



            SqlCommand komut = new SqlCommand();//ekler
            komut.CommandText = String.Format("update Products set ProductName='{0}',UnitPrice={1},UnitsInStock={2} where ProductID={3} ", txtUrunadi.Text, nmrcFiyat.Value, nmrcStok.Value, txtUrunadi.Tag);
            komut.Connection = baglanti;
            baglanti.Open();
            int eklenti = komut.ExecuteNonQuery();
            baglanti.Close();
            if (eklenti > 0)
            {
                MessageBox.Show("güncellenmiştir");
                eklem();

            }
            else
            {
                MessageBox.Show("hata oluştu");
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                int ıd = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);
                SqlCommand komut=new SqlCommand(String.Format("delete products where ProductID={0},",ıd,baglanti));
                komut.Connection = baglanti;
                baglanti.Open();
                int eklenti=komut.ExecuteNonQuery();
                baglanti.Close();
                if (eklenti>0)
                {
                    MessageBox.Show("silindi");
                }
                else
                {
                    MessageBox.Show("hatalı");
                }
            }
        }
    }
}
