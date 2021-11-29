using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace FinalProject.Member
{
    public partial class MemberPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Hello, " + Session["username"] ;  //fetching username from session data
            FinalProject.ServiceReference1.Service1Client client = new FinalProject.ServiceReference1.Service1Client();
            //string mystr = client.GetVerifierString("5");
            //Stream img = client.GetImage(mystr);

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ViewMyCourses.aspx"); //redirecting to vi
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie mycookies = new HttpCookie("MemberCookieId");
            mycookies.Expires = DateTime.Now.AddMonths(-6);
            Response.Cookies.Add(mycookies); //deleting cookies
            Session["username"] = null;
            Session["role"] = null; //resetting session data
            Response.Redirect("MemberLogin.aspx"); // Change the internal value to login page.  
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewAvailableCourses.aspx"); //redirecting to vi
        }
    }
}