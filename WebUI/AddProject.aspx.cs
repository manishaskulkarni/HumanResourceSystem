using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRS.Controller;
using Entity;

namespace WebUI
{
    public partial class AddProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnImgAdd.Enabled = true;
            txtCreated.Text = Session["UserId"].ToString();
            txtCreated.Enabled = false;
        }

        protected void btnImgAdd_Click(object sender, ImageClickEventArgs e)
        {
            Project emp3 = new Project();
            emp3.ProjectName = txtname.Text;
            emp3.ClientName = txtcname.Text;
            emp3.StartDate = txtSdate.Text;
            emp3.EndDate = txtEdate.Text;
            emp3.Budget = Convert.ToDouble(txtBudget.Text);
            emp3.CreatedBy = txtCreated.Text;
            int result = 0;
            result = new ProjectController().AddProject(emp3);
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