using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Hosting;
using System.IO;
using System.Xml;

namespace service1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string addUser(string User, string password, int role)
        {
            string filename = null;
            if (role == 2) filename = "members.xml";
            if (role == 3) filename = "staff.xml";
            string p = HostingEnvironment.ApplicationPhysicalPath;
            string filePath = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, "App_Data", filename);

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode user_node = doc.CreateElement("User");
            XmlNodeList userlst = doc.SelectNodes("Users/User/username");
            foreach (XmlNode res in userlst)
            {
                Console.WriteLine(res.InnerText);
                if (res.InnerText == User)
                {
                    return "exist";
                }
            }
            XmlNode username = doc.CreateElement("username");
            username.InnerText = User;   // add value to it
            user_node.AppendChild(username);      //add to parent node

            XmlNode password1 = doc.CreateElement("password");
            password1.InnerText = password;   // add value to it
            user_node.AppendChild(password1);      //add to parent node

            doc.DocumentElement.AppendChild(user_node);

            doc.Save(filePath);


            return "success";
        }

        public string searchUser(string User, string password, int role)
        {
            string filename = null;
            if (role == 2) filename = "members.xml";
            if (role == 3) filename = "staff.xml";

            string p = HostingEnvironment.ApplicationPhysicalPath;
            string filePath = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, "App_Data", filename);

            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(filePath);
                reader.WhitespaceHandling = WhitespaceHandling.None;
                while (reader.Read())
                {
                    if((reader.NodeType == XmlNodeType.Element) && (reader.Name == "username"))
                    {
                        string sname;
                        sname = reader.ReadString();
                        if(sname == User)
                        {
                            reader.Read();
                            if((reader.NodeType == XmlNodeType.Element) && (reader.Name == "password"))
                            {
                                string spass;
                                spass = reader.ReadString();
                                if(spass == password)
                                {
                                    return "success";
                                }
                            }
                        }
                    }
                }
                return "unsuccess";
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
}
