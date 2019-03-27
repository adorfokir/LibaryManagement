using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibaryManagement
{
    public class Connection
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BJS3K5M;Initial Catalog=Libary_Management;Integrated Security=True");
        public SqlConnection ActiveCon()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
    }
}
