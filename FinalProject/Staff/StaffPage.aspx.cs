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
            Response.Redirect("AddCourse.aspx"); //redirects to add course page
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteCourse.aspx"); //redirects to delete course page
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie mycookies = new HttpCookie("StaffCookieId");
            mycookies.Expires = DateTime.Now.AddMonths(-6);
            Response.Cookies.Add(mycookies); //deleting cookies
            Session["username"] = null; //resetting session data
            Session["role"] = null;
            Response.Redirect("StaffLogin.aspx"); // Redirects to login page.
        }
    }
}