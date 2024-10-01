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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DataTable1TableAdapter ds = new  DataSet1TableAdapters.DataTable1TableAdapter();
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();

            SqlCommand komut = new SqlCommand("select * from Kulupler",bgl.baglanti());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            cmbOgrenciKULUP.DisplayMember = "Ad";
            cmbOgrenciKULUP.ValueMember = "Id";
            cmbOgrenciKULUP.DataSource = dt;
        }
        string c = "";
        private void btnEkle_Click(object sender, EventArgs e)
        {
          


            ds.OgrenciEkle(txtOgrenciAD.Text,txtOgrenciSOYAD.Text,byte.Parse(cmbOgrenciKULUP.SelectedValue.ToString()),c);
            MessageBox.Show("Öğrenci eklendi...");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void cmbOgrenciKULUP_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOgrenciID.Text = cmbOgrenciKULUP.SelectedIndex.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(Convert.ToInt32(txtOgrenciID.Text));
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            ds.OgrenciGuncele(txtOgrenciAD.Text, txtOgrenciSOYAD.Text, byte.Parse(cmbOgrenciKULUP.SelectedValue.ToString()),c,int.Parse(txtOgrenciID.Text));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtOgrenciID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtOgrenciAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtOgrenciSOYAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            
            // Herhangi bir alan tıklanınca kulubu ona göre değişmesi
            cmbOgrenciKULUP.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            
            // Herhangi bir alana tıklayınca cinsiyet Radio butonları seçili olması
            if (dataGridView1.Rows[secilen].Cells[4].Value.ToString() == "Erkek")
            {
                radioButton2.Checked = true;
            }
            if (dataGridView1.Rows[secilen].Cells[4].Value.ToString() == "Kız")
            {
                radioButton1.Checked = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true) c = "Kız";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true) c = "Erkek";
        }
    }
}
