using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KutuphaneProject
{
    class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-090J43E4\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
