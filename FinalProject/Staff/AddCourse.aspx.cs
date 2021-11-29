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
            try {
                FinalProject.ServiceReference1.Service1Client client = new FinalProject.ServiceReference1.Service1Client();
                string courseName = TextBox1.Text.ToString();
                string courseCode = TextBox2.Text.ToString();
                int seats = Int32.Parse(TextBox3.Text.ToString());

                if (courseName.Length == 0 || courseCode.Length == 0 || seats <= 0)
                {
                    Label1.Text = "Please enter a valid value in all fields."; //validating inputs
                    return;
                }

                string response = client.addCourse(courseName, courseCode, seats);
                if (response == "exist")
                {
                    Label1.Text = "Course Already Exists. Please add a different course.";
                }
                else
                {
                    Label1.Text = "Course Added Successfully.";
                }
            }
            catch(FormatException ex) {
                Label1.Text = ex.Message; //covering all invalid inputs of non integer or null type for seats
                return;
            }
            
        }
    }
}