using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Imaging;
using System.IO;

namespace FinalProject.Member
{
    public partial class imageProcess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            FinalProject.ServiceReference2.ServiceClient client = new FinalProject.ServiceReference2.ServiceClient();
            string mystr, userLen;
            if (Session["generatedString"] == null)
            {

                userLen = "6";                       // Assigning userLen to 6
                mystr = client.GetVerifierString(userLen);   // Retreiving a random string
                Session["generatedString"] = mystr;        // Storing in the session variable
            }
            else
            {
                mystr = Session["generatedString"].ToString();
            }
            Stream mystream = client.GetImage(mystr);
            System.Drawing.Image myImage = System.Drawing.Image.FromStream(mystream);  // Draw the image
            Response.ContentType = "image/jpeg";
            myImage.Save(Response.OutputStream, ImageFormat.Jpeg);
        }
    }
}