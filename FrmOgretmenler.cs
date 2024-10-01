using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Okul
{
    public partial class FrmOgretmenler : Form
    {
        public FrmOgretmenler()
        {
            InitializeComponent();
        }

        public string name;


        private void FrmOgretmenler_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulup frm = new FrmKulup();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDersler frm = new FrmDersler();
            frm.Show();
        }

        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            FrmOgrenci frm = new FrmOgrenci();  
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar frm = new FrmSinavNotlar();  
            frm.Show();
        }
    }
}
