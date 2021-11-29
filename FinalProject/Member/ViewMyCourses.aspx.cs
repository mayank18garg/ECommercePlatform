using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.Member
{
    public partial class ViewCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FinalProject.ServiceReference1.Service1Client client = new FinalProject.ServiceReference1.Service1Client();
            string[] response = client.viewMyCourses(Session["username"].ToString()); //calling the service to fetch all registered by students
            if(response.Length ==0 || response == null)
            {
                Label1.Text = "You dont have any subjects registered yet!";
                return;
            }
            foreach(var subs in response)
            {
                Label1.Text += (subs + "    "); //displaying all the course codes
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie mycookies = new HttpCookie("MemberCookieId");
            mycookies.Expires = DateTime.Now.AddMonths(-6);
            Response.Cookies.Add(mycookies); //deleting cookies
            Session["username"] = null;
            Session["role"] = null; //resetting session data
            Response.Redirect("MemberLogin.aspx"); // Change the internal value to login page.  
        }
    }
}