using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ado.net
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data source = .; initial catalog =Northwind;user = sa" +
           ";password=1234");
        private void Form2_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Categories", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            //İD LERİ ENGELLE(İSTEDİĞİN KOLONLARI)
            dataGridView1.Columns["CategoryID"].Visible = false;
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi1 = txtUrunadi.Text;
            decimal fiyat1 = nmrcFiyat.Value;
            decimal stok1 = nmrcStok.Value;

            SqlCommand komut = new SqlCommand();
            
            komut.CommandText = String.Format("insert into Categories(CategoryName)values('{0}')", adi1);  
            komut.Connection = baglanti;
            baglanti.Open();
            int eklenti = komut.ExecuteNonQuery();
            baglanti.Close();
            if (eklenti > 0)
            {
                MessageBox.Show("eklenmiştir");

            }
            else
            {
                MessageBox.Show("hata oluştu");
            }

        }
    }
}
