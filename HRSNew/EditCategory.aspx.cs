using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using HRS.Controller;
using Entity;

namespace HRSNew
{
    public partial class EditCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Session["Catid"]);
                Category cat = new Category();
                cat.CatId = id;
                DataSet result;
                result = new HRS.Controller.CategoryController().SearchCategoryById(cat);
                txtName.Text = result.Tables[0].Rows[0]["CatName"].ToString();
                txtDesc.Text = result.Tables[0].Rows[0]["CatDescription"].ToString();
                txtCreated.Text = result.Tables[0].Rows[0]["CreatedBy"].ToString();
                btnImgEdit.Enabled = true;
                txtCreated.Text = Session["UserId"].ToString();
                txtCreated.Enabled = false;
            }
        }

        protected void btnImgEdit_Click(object sender, ImageClickEventArgs e)
        {
            Category category = new Category();
            category.CatId = Convert.ToInt32(Session["Catid"]);
            category.CatName = txtName.Text;
            category.CatDesc = txtDesc.Text;
            category.CreatedBy = txtCreated.Text;
            int result = 0;
            result = new HRS.Controller.CategoryController().EditCategory(category);
            if (result >= 0)
            {
                lblmsg.Text = "Record updated Successfully";
            }
            else
            {
                lblmsg.Text = "Record is not updated Successfully";
            }
        }
    }
}