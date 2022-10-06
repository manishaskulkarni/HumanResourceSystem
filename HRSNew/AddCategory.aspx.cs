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
    public partial class AddCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            imgBtnAdd.Enabled = true;
            txtCreated.Text = Session["UserId"].ToString();
            txtCreated.Enabled = false;
        }

        /// <summary>
        /// method to add category to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        protected void imgBtnAdd_Click(object sender, ImageClickEventArgs e)
        {
            Category cat = new Category();
            cat.CatName =  txtname.Text;
                cat.CatDesc = txtdesc.Text;
                cat.CreatedBy = txtCreated.Text;
                int result = 0;
                result = new HRS.Controller.CategoryController().AddCategory(cat);   //the addcat method written in controller is invoked here
                if (result >= 0)
                {
                    lblmsg.Text = "Category Added  successfully";
                }
                else
                {
                    lblmsg.Text = " Category not Added ";
                }
            }
    }
}