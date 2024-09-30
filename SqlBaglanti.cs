using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Okul
{

    public class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6LPFTLN\\SQLEXPRESS;Initial Catalog=OkulProjesi;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            return baglanti;
        }
    }
}
