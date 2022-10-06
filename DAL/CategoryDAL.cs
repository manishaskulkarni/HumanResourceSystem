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
  public class CategoryDAL
    {
        /// <summary>
        /// This method is used to add new category for category db 
        /// which returns a integer value
        /// </summary>
        /// <param name="cat"></param>
        /// <returns></returns>
        public int AddCategory(Category cat)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("Addcategory");
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlparameter = new SqlParameter();
            com.Parameters.AddWithValue("@catname", cat.CatName);
            com.Parameters.AddWithValue("@catdesc", cat.CatDesc);
            com.Parameters.AddWithValue("@CreatedBy", cat.CreatedBy);
            com.Connection = con;
            con.Open();//connected architecture
            int result = Convert.ToInt32(com.ExecuteNonQuery());// other options are com.ExecuteScalar,com.ExecuteReader
            con.Close();
            return result;
        }
        /// <summary>
        /// the below method is used to update the category details with the return type int.
        /// </summary>
        /// <param name="cat4"></param>
        /// <returns></returns>
        public int EditCategory(Category cat)
        {
            SqlConnection con = Connection.GetConnection();

            SqlCommand com = new SqlCommand("editcategory");
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter("@catid", cat.CatId);
            com.Parameters.Add(sqlParameter);
            com.Parameters.AddWithValue("@catname", cat.CatName);
            com.Parameters.AddWithValue("@catdescription", cat.CatDesc);
            com.Parameters.AddWithValue("@CreatedBy", cat.CreatedBy);
            com.Connection = con;
            con.Open();    //Connected architecture
            int result = com.ExecuteNonQuery();     //other option we can execute-com.ExecuteScalar,com.ExecuteReader
            con.Close();
            return result;
        }
        /// <summary>
        /// this method is used to delete a particular record from the category table
        /// </summary>
        /// <param name="cat"></param>
        /// <returns></returns>
        public int DeleteCategory(Category cat)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("deletecategory");
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter("@catid", cat.CatId);
            com.Parameters.Add(sqlParameter);
            com.Connection = con;
            con.Open();//Connected architecture
            int result = com.ExecuteNonQuery();//other option we can execute-com.ExecuteScalar,com.ExecuteReader
            con.Close();
            return result;
        }
        /// <summary>
        /// This method with return type dataset is used to search category through category name,
        /// and it is a disconnected architecture where data-adopter is used as a bridge bwt dataset and db
        /// </summary>
        /// <param name="CatName"></param>
        /// <returns></returns>
        public DataSet SearchCategoryByName(String CatName)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("SearchCatByName");
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Catname", CatName);
            com.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        /// <summary>
        /// This method with return type dataset is used to search category through category Id which is used to perform edit operation,
        /// and it is a connected architecture 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public DataSet SearchCategoryById(Category category)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand com = new SqlCommand("SearchCategoryById");
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = Connection.GetConnection();
            com.Parameters.AddWithValue("@catid", category.CatId);
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
