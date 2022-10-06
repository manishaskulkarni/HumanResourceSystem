using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRSNew
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //User user = new User() { UserID = txtUserId.Text, Password = txtpassword.Text };
            //int result = 0;
            //try
            //{
            //    result = new HrsController.UserController().LogIn(user);
            //    if (result == 1)
            //    {
            //        Session["userId"] = txtUserId.Text;
            //        Response.Redirect("Home.aspx");
            //    }
            //    else
            //    {
            //        lblMsg.Text = "Log In failed";
            //    }
            //}
            //catch
            //{
            //    lblMsg.Text = "error recorded ";
            //    //Response.Redirect("Error.html");
            //}
        }
    }
}