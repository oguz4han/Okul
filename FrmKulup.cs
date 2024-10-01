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

namespace Okul
{
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kulupler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void Temizle()
        {
            txtKulupAD.Text = "";
            txtKulupID.Text = "";
        }
        private void FrmKulup_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kulupler (Ad) values (@p1) ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKulupAD.Text);
            komut.ExecuteNonQuery();
            Temizle();
            MessageBox.Show("Kulup eklendi.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKulupID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKulupAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Kulupler where Id=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKulupID.Text);
            komut.ExecuteNonQuery();
            Temizle();
            MessageBox.Show("Kulup silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" update Kulupler set Ad=@p1 where Id=@p2 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKulupAD.Text);
            komut.Parameters.AddWithValue("@p2", txtKulupID.Text);
            komut.ExecuteNonQuery();
            Temizle();
            MessageBox.Show("Kulup güncellendi.");
        }
    }
}
