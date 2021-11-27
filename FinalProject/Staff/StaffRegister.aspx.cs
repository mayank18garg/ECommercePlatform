using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.Staff
{
    public partial class StaffRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            FinalProject.ServiceReference1.Service1Client client = new FinalProject.ServiceReference1.Service1Client();
            string response = client.addUser(UserInput.Text, PasswordInput.Text, 3);  // Adding the user by manipulating XML file
            if (response.Equals("success"))
            {
                Session["registration1"] = "success";
                Response.Redirect("StaffLogin.aspx");
            }
            else if (response.Equals("exist"))
            {
                Error.Text = "Username already exist! Provide a new username";
            }
           /* else if (!Session["generatedString"].Equals(textInput1.Text))    // Comparing input string and random string
            {

                Error.Text = "The string entered is incorrect so please try again!";
            }*/
            else
            {
                //  Error.Text = "Username or password is incorrect!!";
                Error.Text = response;
            }
        }
    }
}