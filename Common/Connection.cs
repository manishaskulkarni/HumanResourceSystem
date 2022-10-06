using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Common
{
    public class Connection
    {
        static SqlConnection con;
        public static SqlConnection GetConnection()
        {

            if (con == null)
            {
                con = new SqlConnection(@"Data Source=SPT-CPU-0112\MANISHA;Initial Catalog=NewHrs;Integrated Security=True");

            }
            return con;
        }
    }
}
