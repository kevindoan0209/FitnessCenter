using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbConection
    {
        public SqlConnection connect()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-M75UEQH\SQLEXPRESS;Initial Catalog=FitnessCenter;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connect.Open();
            return connect;
        }
    }
}
