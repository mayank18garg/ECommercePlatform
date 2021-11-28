using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class MemberRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Register_Click(object sender, EventArgs e)
    {
           
        FinalProject.ServiceReference1.Service1Client client = new FinalProject.ServiceReference1.Service1Client();
        if (!Session["generatedString"].Equals(textInput1.Text))    // Comparing input string and random string
        {
            Error.Text = "The string entered is incorrect so please try again!";
        }
        else {
            string response = client.addUser(UserInput.Text, PasswordInput.Text, 2);
            if (response.Equals("success"))
            {
                //  Error.Text = "User has been registered Successfully!";
                Session["registration"] = "success";
                Response.Redirect("MemberLogin.aspx");
            }
            else if (response.Equals("exist"))
            {
                Error.Text = "Username already exist! Provide a new username";
            }
        }
    }
}

