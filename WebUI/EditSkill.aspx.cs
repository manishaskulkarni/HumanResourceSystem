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
    public partial class EditSkill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Session["SkillID"]);
                Skill sk = new Skill();
                sk.SkillId = id;
                DataSet resultSkill;
                resultSkill = new SkillsController().SearchSkillById(sk);
                if (resultSkill.Tables[0].Rows.Count > 0)
                {
                    txtName.Text = resultSkill.Tables[0].Rows[0]["SkillName"].ToString();
                    txtDesc.Text = resultSkill.Tables[0].Rows[0]["SkillDescription"].ToString();
                    // txtSECID.Text = result.Tables[0].Rows[0]["CatID"].ToString();

                    txtcreated.Text = resultSkill.Tables[0].Rows[0]["CreatedBy"].ToString();
                    txtcreated.Enabled = false;
                }
                DataSet resultCat = new SkillsController().SelectCat();
                ddl.DataSource = resultCat;

                ddl.DataTextField = "CatName";
                ddl.DataValueField = "CatID";
                ddl.DataBind();
                ddl.SelectedIndex = ddl.Items.IndexOf(ddl.Items.FindByText(resultSkill.Tables[0].Rows[0]["CatName"].ToString()));
            }
        }

        protected void btnImgEdit_Click(object sender, ImageClickEventArgs e)
        {
            Skill skl = new Skill();
            skl.SkillId = Convert.ToInt32(Session["SkillId"]);
            skl.SkillName = txtName.Text;
            skl.SkillDescription = txtDesc.Text;
            skl.CategoryID = Convert.ToInt32(ddl.SelectedValue);
            skl.CreatedBy = txtcreated.Text;
            int result = 0;
            result = new SkillsController().EditSkill(skl);
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