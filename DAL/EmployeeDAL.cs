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
   public class EmployeeDAL
    {
        public int AddEmployee(Employee emp)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("Addemployee");
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter();
            // com.Parameters.AddWithValue("@empid", emp.ID);
            com.Parameters.AddWithValue("@empfname", emp.FirstName);
            com.Parameters.AddWithValue("@emplname", emp.LastName);
            com.Parameters.AddWithValue("@empdob", emp.DateOfBirth);
            com.Parameters.AddWithValue("@empemailaddress", emp.Email);
            com.Parameters.AddWithValue("@empdoj", emp.DateOfJoin);
            com.Parameters.AddWithValue("@CreatedBy", emp.CreatedBy);
            com.Connection = con;
            con.Open();//Connected architecture
            int result = com.ExecuteNonQuery();//other option we can execute-com.ExecuteScalar,com.ExecuteReader
            con.Close();
            return result;
        }
        public int EditEmployee(Employee emp)
        {
            SqlConnection con = Connection.GetConnection();

            SqlCommand com = new SqlCommand("editemployee");
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter("@empid", emp.ID);
            com.Parameters.Add(sqlParameter);
            com.Parameters.AddWithValue("@empfname", emp.FirstName);
            com.Parameters.AddWithValue("@emplname", emp.LastName);
            com.Parameters.AddWithValue("@empdob", emp.DateOfBirth);
            com.Parameters.AddWithValue("@empemailaddress", emp.Email);
            com.Parameters.AddWithValue("@empdoj", emp.DateOfJoin);
            com.Parameters.AddWithValue("@CreatedBy", emp.CreatedBy);
            com.Connection = con;
            con.Open();//Connected architecture
            int result = com.ExecuteNonQuery();//other option we can execute-com.ExecuteScalar,com.ExecuteReader
            con.Close();
            return result;
        }
        public int DeleteEmployee(Employee emp)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("Deleteemployee");
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter("@empid", emp.ID);
            com.Parameters.Add(sqlParameter);
            com.Connection = con;
            con.Open();//Connected architecture
            int result = com.ExecuteNonQuery();//other option we can execute-com.ExecuteScalar,com.ExecuteReader
            con.Close();
            return result;

        }
        public DataSet SearchEmpByName(String empfname, String emplname)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("SearchemployeeByName");
            com.CommandType = CommandType.StoredProcedure;
            //SqlParameter sqlParameter = new SqlParameter();

            com.Parameters.AddWithValue("@Empfname", empfname);
            com.Parameters.AddWithValue("@emplname", emplname);

            // com.Parameters.Add(sqlParameter);
            com.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet SearchEmpById(Employee EmpId)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("ViewEmp");
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = Connection.GetConnection();
            com.Parameters.AddWithValue("@Empid", EmpId.ID);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.SelectCommand = com;
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
    }
}
