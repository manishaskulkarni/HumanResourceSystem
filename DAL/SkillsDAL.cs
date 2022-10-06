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
   public class SkillsDAL
    {
        public int AddSkill(Skill skill)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("Addskills");
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlparameter = new SqlParameter();
            com.Parameters.AddWithValue("@skillname", skill.SkillName);
            com.Parameters.AddWithValue("@skilldesc", skill.SkillDescription);
            com.Parameters.AddWithValue("@catid", skill.CategoryID);
            com.Parameters.AddWithValue("@createdby", skill.CreatedBy);
            
            com.Connection = con;
            con.Open();//connected architecture
            int result = Convert.ToInt32(com.ExecuteNonQuery());//com.ExecuteScalar,com.ExecuteReader
            con.Close();
            return result;
        }
        public int EditSkill(Skill skill)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("SkillEdit");
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter("@SkillId", skill.SkillId);
            com.Parameters.Add(sqlParameter);
            com.Parameters.AddWithValue("@SkillName", skill.SkillName);
            com.Parameters.AddWithValue("@SkillDesc", skill.SkillDescription);
            com.Parameters.AddWithValue("@CatId", skill.CategoryID);
            com.Parameters.AddWithValue("@CreatedBy", skill.CreatedBy);
            
            com.Connection = con;
            con.Open();//Connected architecture
            int result = com.ExecuteNonQuery();//other option we can execute-com.ExecuteScalar,com.ExecuteReader
            con.Close();
            return result;
        }
        public int DeleteSkill(Skill skl)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("SkillDelete");
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter("@skillname", skl.SkillName);
            com.Parameters.Add(sqlParameter);
            com.Connection = con;
            con.Open();//Connected architecture
            int result = com.ExecuteNonQuery();//other option we can execute-com.ExecuteScalar,com.ExecuteReader
            con.Close();
            return result;

        }
        public DataSet SearchSkillByName(String SkillName)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("SearchSkillByName");
            com.CommandType = CommandType.StoredProcedure;
            //SqlParameter sqlParameter = new SqlParameter();

            com.Parameters.AddWithValue("@skillname", SkillName);
            // com.Parameters.Add(sqlParameter);
            com.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;


        }
        public DataSet SearchSkillById(Skill skill)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("SearchSkillById");
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = Connection.GetConnection();
            com.Parameters.AddWithValue("@skillId", skill.SkillId);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.SelectCommand = com;
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet SelectCat()
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("DropDownCat");
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = Connection.GetConnection();
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
