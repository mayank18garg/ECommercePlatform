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
            FinalProject.ServiceReference2.ServiceClient client = new FinalProject.ServiceReference2.ServiceClient();
            string mystr = client.GetVerifierString("5");
            Stream img = client.GetImage(mystr);

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ViewMyCourses.aspx"); //redirecting to vi
        }
    }
}