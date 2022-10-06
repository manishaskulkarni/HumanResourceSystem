using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common;
using Entity;

namespace DAL
{
    public class UserDAL
    {
        public int LogIn(User user)
        {
            int result = 0;
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("AuthenticateUser");
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameterUser = new SqlParameter("@UserID", user.UserID);
            SqlParameter sqlParameterPwd = new SqlParameter("@Password", user.Password);

            com.Parameters.Add(sqlParameterUser);
            com.Parameters.Add(sqlParameterPwd);

            com.Connection = con;
            con.Open();//connected architecture
            result = Convert.ToInt32(com.ExecuteScalar());//com.ExecuteScalar,com.ExecuteReader            
            con.Close();
            return result;
        }
    }
}
