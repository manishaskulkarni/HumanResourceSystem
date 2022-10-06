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
namespace WebUI
{
    public partial class AddCat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            imgBtnAdd.Enabled = true;
            txtCreated.Text = Session["UserId"].ToString();
            txtCreated.Enabled = false;
        }

        protected void imgBtnAdd_Click(object sender, ImageClickEventArgs e)
        {
            Category cat = new Category();
            cat.CatName = txtname.Text;
            cat.CatDesc = txtdesc.Text;
            cat.CreatedBy = txtCreated.Text;
            int result = 0;
            result = new HRS.Controller.CategoryController().AddCategory(cat);             //the addcat method written in controller is invoked here
            if (result >= 0)
            {
                lblmsg.Text = "Record inserted successfully";
            }
            else
            {
                lblmsg.Text = "Record not inserted ";
            }
        }
    }
}