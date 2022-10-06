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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //btnImgAdd.Enabled = true;
            //txtCReated.Text = Session["UserId"].ToString();
            //txtCReated.Enabled = false;
        }

        protected void btnImgAdd_Click(object sender, ImageClickEventArgs e)
        {
            Employee emp = new Employee();
            //emp.ID = Convert.ToInt32(txtID.Text);
            emp.FirstName = txtFname.Text;
            emp.LastName = txtLname.Text;
            emp.DateOfBirth = txtDob.Text;
            emp.Email = txtmail.Text;
            emp.DateOfJoin = txtDoj.Text;
            emp.CreatedBy = txtCReated.Text;
            int result = 0;
            result = new EmployeeController().AddEmployee(emp);
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