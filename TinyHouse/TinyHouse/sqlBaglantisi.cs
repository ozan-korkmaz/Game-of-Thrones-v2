using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyHouse
{
    internal class sqlBaglantisi
    {
        public SqlConnection baglanti()  //bu methodu kullandığında bağlantıyı kapatmayı unutma
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-TOI8U7V\\OZAN;Initial Catalog=TinyHouse;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
