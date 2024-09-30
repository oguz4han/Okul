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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        public string numara;

        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {

            try
            {

                SqlCommand komut = new SqlCommand(" select Ogrenciler.Ad as [Öğrenci Adı],Dersler.Ad as [Ders Adı]," +
                    "Sinav1,Sinav2,Sinav3,Proje,Ortalama,Durum " +
                    "from Notlar " +
                    "inner join Ogrenciler on Notlar.OgrenciID=Ogrenciler.Id " +
                    "inner join Dersler on Notlar.DersID=Dersler.Id " +
                    "where OgrenciId=@p1", bgl.baglanti());


                komut.Parameters.AddWithValue("@p1", numara);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                this.Text = dt.Rows[0]["Öğrenci Adı"].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata :" + ex.Message);
            }


        }
    }
}
