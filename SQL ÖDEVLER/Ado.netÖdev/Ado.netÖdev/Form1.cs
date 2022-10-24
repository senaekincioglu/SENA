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

namespace Ado.netÖdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1PA657B;Initial catalog=Northwind;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

            urunlistesi();
        }
        private void urunlistesi()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Products ",baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("UrunEkle",baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@urunadi",textBox1.Text);
            cmd.Parameters.AddWithValue("@fiyat",numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@stok", numericUpDown2.Value);

            baglanti.Open();
            int ekt = cmd.ExecuteNonQuery();
            baglanti.Close();
            if (ekt>0)
            {
                MessageBox.Show("kayıt eklendi");
                urunlistesi();
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }


        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                SqlCommand komut = new SqlCommand("Urunsil",baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                string urunadi = Convert.ToString
                    (dataGridView1.CurrentRow.Cells["ProductName"].Value);
                komut.Parameters.AddWithValue("@urunadi",urunadi);
                baglanti.Open();
                int etk = komut.ExecuteNonQuery();
                baglanti.Close();
                if (etk>0)
                {
                    MessageBox.Show("kayıt silindi");
                }
                else
                {
                    MessageBox.Show("hatalı");
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("kategoriguncelle",baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ıd", dataGridView1.CurrentRow.Cells["CategoryID"].Value);
            cmd.Parameters.AddWithValue("@adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@tanim", textBox1.Text);
            baglanti.Open();
            int etk = cmd.ExecuteNonQuery();
            baglanti.Close();
            if (etk > 0)
            {
                MessageBox.Show("kayıt güncellendi");
            }
            else
            {
                MessageBox.Show("hatalı");
            }
            urunlistesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            numericUpDown1.Tag = dataGridView1.CurrentRow.Cells["ProductID"].Value;
            numericUpDown2.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["UnitPrice"].Value);
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int ıd= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("kategoriguncelle", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@tanim", textBox1.Text);
            cmd.Parameters.AddWithValue("@ıd",ıd);
            int etk = cmd.ExecuteNonQuery();
            baglanti.Close();
            if (etk > 0)
            {
                MessageBox.Show("kayıt güncellendi");
            }
            else
            {
                MessageBox.Show("hatalı");
            }
            urunlistesi();
        }
    }
}
