using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DerslerTableAdapter ds = new DataSet1TableAdapters.DerslerTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtDersAD.Text);
            MessageBox.Show("Ders eklendi...");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txtDersID.Text));
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txtDersAD.Text, byte.Parse(txtDersID.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtDersID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtDersAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
