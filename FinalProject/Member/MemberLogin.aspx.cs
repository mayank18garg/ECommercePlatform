using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.Member
{
    public partial class MemberLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["registration"].Equals("success"))
            {
                Label5.Text = "You have successfully Registered. Login to Continue!";
                Session["registration"] = "";
            }

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            FinalProject.ServiceReference1.Service1Client client = new FinalProject.ServiceReference1.Service1Client();
            string response = client.searchUser(UserInput.Text, PasswordInput.Text, 2);
            if (response.Equals("success"))
            {
                HttpCookie mycookies = new HttpCookie("StaffCookieId");  // Clearing the cookies if required 
                mycookies.Expires = DateTime.Now.AddMonths(-6);
                Response.Cookies.Add(mycookies);

                //HttpCookie mycookies = new HttpCookie("MemberCookieId");
                mycookies = new HttpCookie("MemberCookieId");
                mycookies["Name"] = UserInput.Text;            // Store username and password in cookies
                //mycookies["Password"] = Cryption.Encrypt(passsword_input.Text);
                mycookies["Password"] = PasswordInput.Text;
                mycookies["role"] = "2";
                mycookies.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(mycookies);
                Session["username"] = UserInput.Text;   // Storing username is session so that it could be used in welcome page
                Session["role"] = "2";
                Response.Redirect("MemberPage.aspx");
            }
            else if (response.Equals("unsuccess"))
            {
                Error.Text = "Username or password is incorrect!!";
            }
            else
            {
                Error.Text = response;
            }
        }
    }
}