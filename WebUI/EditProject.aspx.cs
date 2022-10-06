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
    public partial class EditProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Session["ProjectId"]);
                Project project = new Project();
                project.ProjectId = id;
                DataSet result;
                result = new ProjectController().SearchProjectById(project);
                txtpname.Text = result.Tables[0].Rows[0]["ProjectName"].ToString();
                txtcname.Text = result.Tables[0].Rows[0]["ClientName"].ToString();
                txtsdate.Text = result.Tables[0].Rows[0]["StartDate"].ToString();
                txtEdate.Text = result.Tables[0].Rows[0]["EndDate"].ToString();
                txtBudget.Text = result.Tables[0].Rows[0]["Budget"].ToString();
                txtCreated.Text = result.Tables[0].Rows[0]["CreatedBy"].ToString();
                btnImgEdit.Enabled = true;
                txtCreated.Text = Session["UserId"].ToString();
                txtCreated.Enabled = false;
            }
        }

        protected void btnImgEdit_Click(object sender, ImageClickEventArgs e)
        {
            Project pjt = new Project();
            pjt.ProjectId = Convert.ToInt32(Session["ProjectId"]);
            pjt.ProjectName = txtpname.Text;
            pjt.ClientName = txtcname.Text;
            pjt.StartDate = txtsdate.Text;
            pjt.EndDate = txtEdate.Text;
            pjt.Budget = Convert.ToDouble(txtBudget.Text);
            pjt.CreatedBy = txtCreated.Text;
            int result = 0;
            result = new ProjectController().EditProject(pjt);
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