using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.Member
{
    public partial class ImgVerifierRegister : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "imageProcess.aspx";
        }
    }
}