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
    public partial class EditEmp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Session["Empid"]);
                Employee emp = new Employee();
                emp.ID = id;
                DataSet result;
                result = new EmployeeController().SearchEmpById(emp);
                txtfn.Text = result.Tables[0].Rows[0]["EmpFname"].ToString();
                txtln.Text = result.Tables[0].Rows[0]["EmpLname"].ToString();
                txtDob.Text = result.Tables[0].Rows[0]["EmpDOB"].ToString();
                txtmail.Text = result.Tables[0].Rows[0]["EmpEmailAddress"].ToString();
                txtDoj.Text = result.Tables[0].Rows[0]["EmpDOJ"].ToString();
                txtcreated.Text = result.Tables[0].Rows[0]["CreatedBy"].ToString();
                btnImgEdit.Enabled = true;
                txtcreated.Text = Session["UserId"].ToString();
                txtcreated.Enabled = false;
            }
        }

        protected void btnImgEdit_Click(object sender, ImageClickEventArgs e)
        {
            Employee emp = new Employee();
            emp.ID = Convert.ToInt32(Session["Empid"]);
            emp.FirstName = txtfn.Text;
            emp.LastName = txtln.Text;
            emp.DateOfBirth = txtDob.Text;
            emp.Email = txtmail.Text;
            emp.DateOfJoin = txtDoj.Text;
            emp.CreatedBy = txtcreated.Text;
            int result = 0;
            result = new EmployeeController().EditEmployee(emp);
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