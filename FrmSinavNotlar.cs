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
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }


        DataSet1TableAdapters.NotlarTableAdapter ds = new DataSet1TableAdapters.NotlarTableAdapter();
        SqlBaglanti bgl = new SqlBaglanti();

        void Listele()
        {
            SqlCommand komut = new SqlCommand("select * from Notlar", bgl.baglanti());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Temizle()
        {
            txtId.Text = "";
            txtSinav1.Text = "";
            txtSinav2.Text = "";
            txtSinav3.Text = "";
            txtProje.Text = "";
            txtOrtalama.Text = "";
            txtDurum.Text = "";
        }

        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Dersler", bgl.baglanti());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            Listele();
            cmbDers.DisplayMember = "Ad";
            cmbDers.ValueMember = "DersId";
            cmbDers.DataSource = dt;
        }
        int notID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            notID = int.Parse( dataGridView1.Rows[secilen].Cells[0].Value.ToString());


            txtId.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSinav1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSinav3.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtProje.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        int sinav1, sinav2, sinav3, proje;
        double ortalama;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            string durum;
            sinav1 = Convert.ToInt16(txtSinav1.Text);
            sinav2 = Convert.ToInt16(txtSinav2.Text);
            sinav3 = Convert.ToInt16(txtSinav3.Text);
            proje = Convert.ToInt16(txtProje.Text);
            ortalama = (sinav1+sinav2+sinav3+proje)/4;

            txtOrtalama.Text = ortalama.ToString();

            if(ortalama >= 50)
            {
                txtDurum.Text = "True";
            }
            else
            {
                txtDurum.Text = "False";
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmbDers.SelectedValue.ToString()), int.Parse(txtId.Text),byte.Parse(txtSinav1.Text), byte.Parse(txtSinav2.Text), byte.Parse(txtSinav3.Text), byte.Parse(txtProje.Text), decimal.Parse(txtOrtalama.Text), bool.Parse(txtDurum.Text),notID);
        }
    }
}
