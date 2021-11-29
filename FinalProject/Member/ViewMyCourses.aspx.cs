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

            foreach(var subs in response)
            {
                Label1.Text += (subs + "    "); //displaying all the course codes
            }

        }
    }
}