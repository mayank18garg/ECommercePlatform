using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.Member
{
    public partial class viewAvailableCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FinalProject.ServiceReference1.Service1Client client = new FinalProject.ServiceReference1.Service1Client();
            string[] response = client.viewAllCourses(Session["username"].ToString());

            foreach (var i in response)
            {
                ListBox1.Items.Add(i);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FinalProject.ServiceReference1.Service1Client client = new FinalProject.ServiceReference1.Service1Client();
            foreach (ListItem lst in ListBox1.Items)
            {
                if (lst.Selected == true)
                {
                    client.registercourse(lst.Text, (string)Session["username"]);
                    Response.Redirect("MemberPage.aspx");
                    break;
                }

            }
        }
    }
}