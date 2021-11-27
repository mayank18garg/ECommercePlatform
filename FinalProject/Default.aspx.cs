using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["registration"] = "";
            Session["registration1"] = "";

            AccessRequest.Text = "The number of Access Requests : " + (int)Application["accessrequest"];
            LabelStartTime.Text = "The Application was last accessed at : " + Application["ApplicationStartTime"];
        }

        protected void MemReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member/MemberRegister.aspx");
        }

        protected void MemberPage_Click(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["MemberCookieId"];
            if ((myCookies == null) || (Session["role"].ToString() != "2")) 
            {
                Response.Redirect("Member/MemberLogin.aspx");
            }
            else if ((Session["role"].ToString() == "2"))
            {
                Response.Redirect("Member/MemberPage.aspx");
            }
        }

        protected void StaffReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff/StaffRegister.aspx");
        }

        protected void StaffPage_Click(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["StaffCookieId"];
            if(myCookies == null || Session["role"].ToString() != "3")
            {
                Response.Redirect("Staff/StaffLogin.aspx");
            }
            else if(Session["role"].ToString() == "3")
            {
                Response.Redirect("Staff/StaffPage.aspx");
            }

        }
    }
}