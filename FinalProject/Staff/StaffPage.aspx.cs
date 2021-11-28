using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.Staff
{
    public partial class StaffPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Hello, " + Session["username"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCourse.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteCourse.aspx");
        }
    }
}