using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.Staff
{
    public partial class DeleteCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FinalProject.ServiceReference1.Service1Client client = new FinalProject.ServiceReference1.Service1Client();
            string courseCode = TextBox1.Text.ToUpper(); //converting all lowercase variable to uppercase(eg. cse to CSE)
            if(courseCode.Length == 0)
            {
                Label1.Text = "Please provide a valid input."; //validating input
                return;
            }
            string response = client.deleteCourse(courseCode);
            Label1.Text = response; //posting response from the service to be viewed by user.
        }
    }
}