using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.Staff
{
    public partial class AddCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FinalProject.ServiceReference1.Service1Client client = new FinalProject.ServiceReference1.Service1Client();
            string courseName = TextBox1.Text.ToString();
            string courseCode = TextBox2.Text.ToString();
            string location = TextBox3.Text.ToString();

            string response = client.addCourse(courseName, courseCode, location);
            if(response == "exist")
            {
                Label1.Text = "Course Already Exists. Please add a different course.";
            }
            else
            {
                Label1.Text = "Course Added Successfully.";
            }
        }
    }
}