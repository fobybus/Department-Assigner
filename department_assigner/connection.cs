using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace department_assigner
{
    internal class connection
    {
        private SqlConnection conn;
        public connection()
        {
            string con_str = @"Data Source=DESKTOP-KTUGFG1\SQL_SERVER;Initial Catalog=dpass;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            conn = new SqlConnection(con_str);
        }

        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}
