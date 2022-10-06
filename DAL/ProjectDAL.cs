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
   public class ProjectDAL
    {
        public int AddProject(Project project)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("Addproject");
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlparameter = new SqlParameter();
            //com.Parameters.AddWithValue("@projectid", project.ProjectId);
            com.Parameters.AddWithValue("@projectname", project.ProjectName);
            com.Parameters.AddWithValue("@clientname", project.ClientName);
            com.Parameters.AddWithValue("@startdate", project.StartDate);
            com.Parameters.AddWithValue("@enddate", project.EndDate);
            com.Parameters.AddWithValue("@budget", project.Budget);
            com.Parameters.AddWithValue("@CreatedBy", project.CreatedBy);

            //com.Parameters.AddWithValue("@empid", emp.ID);
            // com.Parameters.Add(sqlparameter);            

            com.Connection = con;
            con.Open();//connected architecture
            int result = Convert.ToInt32(com.ExecuteNonQuery());//com.ExecuteScalar,com.ExecuteReader
            con.Close();
            return result;
        }
        public int EditProject(Project pjt)
        {
            SqlConnection con = Connection.GetConnection();

            SqlCommand com = new SqlCommand("editProject");
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter("@ProjectId", pjt.ProjectId);
            com.Parameters.Add(sqlParameter);
            com.Parameters.AddWithValue("@ProjectName", pjt.ProjectName);
            com.Parameters.AddWithValue("@ClientName", pjt.ClientName);
            com.Parameters.AddWithValue("@StartDate", pjt.StartDate);
            com.Parameters.AddWithValue("@EndDate", pjt.EndDate);
            com.Parameters.AddWithValue("@Budget", pjt.Budget);
            com.Parameters.AddWithValue("@CreatedBy", pjt.CreatedBy);
            com.Connection = con;
            con.Open();//Connected architecture
            int result = com.ExecuteNonQuery();//other option we can execute-com.ExecuteScalar,com.ExecuteReader
            con.Close();
            return result;
        }
        public int DeleteProject(Project pjt)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("deleteproject");
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter("@projectid", pjt.ProjectId);
            com.Parameters.Add(sqlParameter);
            com.Connection = con;
            con.Open();//Connected architecture
            int result = com.ExecuteNonQuery();//other option we can execute-com.ExecuteScalar,com.ExecuteReader
            con.Close();
            return result;
        }
        public DataSet SearchProjectByName(String ProjectName)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("searchproject");
            com.CommandType = CommandType.StoredProcedure;
            //SqlParameter sqlParameter = new SqlParameter();

            com.Parameters.AddWithValue("@projectname", ProjectName);
            // com.Parameters.Add(sqlParameter);
            com.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;


        }
        public DataSet SearchProjectById(Project project)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("SearchProjectById");
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = Connection.GetConnection();
            com.Parameters.AddWithValue("@ProjectId", project.ProjectId);
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
