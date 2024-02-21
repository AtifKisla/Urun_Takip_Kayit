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

namespace Urun_Takip_Kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-CPG9G0OG\\SQLEXPRESS;Initial Catalog=URUN;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Kategori(Ad) Values (@p1)", baglanti);
            //komut2.Parameters.AddWithValue("@p1",txtKategoriAd.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme gerçekleştirildi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from Kategori KategoriID = @p1", baglanti);
            //komut3.Parameters.AddWithValue("@p1",txtKategoriID.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleştirildi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * From Kategori", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("update Kategori set KategoriAd = @p1 where KategoriID=  @p2 ", baglanti);
            //komut4.Parameters.AddWithValue("@p1",KategoriAd.Text);        
            //komut4.Parameters.AddWithValue("@p2",KategoriID.Text);

            komut4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleştirildi.");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select from Kategori where KategoriAd = @p1",baglanti);
            //komut.Parameters.AddWithValue("@p1"KategoriAd.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }
    }
}
//Data Source=LAPTOP-CPG9G0OG\SQLEXPRESS;Initial Catalog=URUN;Integrated Security=True
