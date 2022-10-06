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
    public partial class SearchCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gvCat_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                Session["CatID"] = gvCat.DataKeys[index].Value.ToString();
                Response.Redirect("EditCategory.aspx");
            }
        }

        protected void btnImgEdit_Click(object sender, ImageClickEventArgs e)
        {
        //    DataSet ds = new CategoryController().SearchCategoryByName(txtName.Text);
        //    gvCat.DataSource = ds.Tables[0];
        //    gvCat.DataBind();
        }
    }
}