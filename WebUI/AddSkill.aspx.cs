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
    public partial class AddSkill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnImgAdd.Enabled = true;
                txtcreated.Text = Session["UserId"].ToString();
                txtcreated.Enabled = false;
                DataSet result = new SkillsController().SelectCat();
                Ddl.DataSource = result;

                Ddl.DataTextField = "CatName";
                Ddl.DataValueField = "CatID";
                Ddl.DataBind();
                //ddlCatSkill.DataSource = result;

                //ddlCatSkill.DataTextField = result.Tables[0].Columns[0].ToString();

                //ddlCatSkill.DataBind();
            }
        }

        protected void btnImgAdd_Click(object sender, ImageClickEventArgs e)
        {
            Skill skill = new Skill();
            skill.SkillName = txtname.Text;
            skill.SkillDescription = txtdesc.Text;
            skill.CategoryID = Convert.ToInt32(Ddl.SelectedValue);
            skill.CreatedBy = txtcreated.Text;
            int result = 0;
            result = new SkillsController().AddSkill(skill);
            if (result >= 0)
            {
                //Response.Write("<script language=javascript>alert('Record added succesfully');</script>");
                //ImageAdd3.Enabled = false;
                lblmsg.Text = "Record added successfully";
            }
            else
            {
                lblmsg.Text = " Skill not Added ";
            }
        }
    }
}