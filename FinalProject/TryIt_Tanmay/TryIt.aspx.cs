using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.TryIt_Tanmay
{
    public partial class TryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
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
            catch (FormatException ex)
            {
                Label1.Text = ex.Message; //covering all invalid inputs of non integer or null type for seats
                return;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            FinalProject.ServiceReference1.Service1Client client = new FinalProject.ServiceReference1.Service1Client();
            string courseCode = TextBox4.Text.ToUpper(); //converting all lowercase variable to uppercase(eg. cse to CSE)
            if (courseCode.Length == 0)
            {
                Label2.Text = "Please provide a valid input."; //validating input
                return;
            }
            string response = client.deleteCourse(courseCode);
            Label2.Text = response; //posting response from the service to be viewed by user.
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            FinalProject.ServiceReference1.Service1Client client = new FinalProject.ServiceReference1.Service1Client();
            string courseCode = TextBox5.Text.ToUpper();
            string userName = TextBox6.Text.ToString();
            if(courseCode.Length == 0 || userName.Length == 0)
            {
                Label3.Text = "Please provide a valid input";
                return;
            }
            string response = client.registercourse(courseCode, userName);
            Label3.Text = response;
        }
    }
}