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
using System.Net;
using System.Drawing;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Web;
using Formatting = Newtonsoft.Json.Formatting;

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


        public string addCourse(string Name, string Code, Int32 seats)
        {
            Course newCourse = new Course();
            CourseRootObject courseObj = new CourseRootObject();
            List<Course> coursesList = new List<Course>();
            string json;
            Boolean exists = false;
            string created = "";

            string path = HttpRuntime.AppDomainAppPath + "\\courses_list.json";

            string jsonData = File.ReadAllText(path);

            courseObj = JsonConvert.DeserializeObject<CourseRootObject>(jsonData);

            if (courseObj.courses != null)
            {
                coursesList = courseObj.courses.ToList<Course>();
                foreach (Course course in coursesList)
                {
                    if (course.Code == Code)
                    {
                        exists = true;
                        return "exist";
                    }
                }
            }

            if (!exists)
            {
                newCourse.Code = Code; newCourse.Name = Name; newCourse.seats = seats;
                newCourse.CourseStudents = new List<string>();
                coursesList.Add(newCourse);

                courseObj.courses = coursesList.ToArray<Course>();
                json = JsonConvert.SerializeObject(courseObj, Formatting.Indented);
                File.WriteAllText(path, json);

                created = "created";
            }
            return created;
        }

        public string registercourse(string courseCode, string userName)
        {
            List<Course> coursesList = new List<Course>();
            CourseRootObject courseObj = new CourseRootObject();
            string path = HttpRuntime.AppDomainAppPath + "\\courses_list.json";

            //user
            string userpath = HttpRuntime.AppDomainAppPath + "\\users_list.json"; // File path to user credentials 
            string jsonUserData = File.ReadAllText(userpath); // reads in the JSON file into a string

            User newUser = new User(); // User object for new user
            UsersRootObject usersObj = new UsersRootObject(); // Object of user
            List<User> usersList = new List<User>(); // List of users to read in existing data and add new users

            usersObj = JsonConvert.DeserializeObject<UsersRootObject>(jsonUserData); // transfers jsonData to the usersObj
            usersList = usersObj.users.ToList<User>();
            //user
            string jsonData = File.ReadAllText(path);
            string json;

            courseObj = JsonConvert.DeserializeObject<CourseRootObject>(jsonData);
            coursesList = courseObj.courses.ToList<Course>();
            foreach (Course course in coursesList)
            {
                if (course.Code == courseCode)
                {
                    course.seats = course.seats - 1;
                    course.CourseStudents.Add(userName);
                    courseObj.courses = coursesList.ToArray<Course>();
                    json = JsonConvert.SerializeObject(courseObj, Formatting.Indented);
                    File.WriteAllText(path, json);

                    var itemToAdd = usersList.SingleOrDefault(r => r.StudentName == userName);
                    if (itemToAdd != null)
                    {
                        itemToAdd.StudentCourses.Add(course.Code);
                    }

                }

            }
            usersObj.users = usersList.ToArray<User>(); // Converts the list to a User object array
            json = JsonConvert.SerializeObject(usersObj, Formatting.Indented); // Converts object to JSON string
            File.WriteAllText(userpath, json); // Writes JSON data to the file

            string ans = string.Format("Course {0} has been registered for user {1}", courseCode, userName);
            return ans;
        }

        public string deleteCourse(string Code)
        {
            CourseRootObject courseObj = new CourseRootObject();
            List<Course> coursesList = new List<Course>();
            string json;
            Boolean exists = false;

            string coursesPath = HttpRuntime.AppDomainAppPath + "\\courses_list.json";
            string usersPath = HttpRuntime.AppDomainAppPath + "\\users_list.json";

            string jsonData = File.ReadAllText(coursesPath);

            courseObj = JsonConvert.DeserializeObject<CourseRootObject>(jsonData);

            if (courseObj.courses != null)
            {
                coursesList = courseObj.courses.ToList<Course>();
                foreach (Course course in coursesList)
                {
                    if (course.Code == Code)
                    {
                        exists = true;
                    }
                }
            }

            if (exists)
            {
                var itemToRemove = coursesList.SingleOrDefault(r => r.Code == Code);
                if (itemToRemove != null)
                {

                    List<User> usersList = new List<User>();
                    UsersRootObject usersObj = new UsersRootObject(); // Object of user

                    string jsonUserData = File.ReadAllText(usersPath);
                    string jsonUser;

                    usersObj = JsonConvert.DeserializeObject<UsersRootObject>(jsonUserData);

                    usersList = usersObj.users.ToList<User>();
                    foreach (var i in itemToRemove.CourseStudents)
                    {
                        foreach (User user in usersList)
                        {
                            if (user.StudentName == i)
                            {
                                int index = user.StudentCourses.IndexOf(Code);
                                if (index != -1)
                                {
                                    user.StudentCourses.RemoveAt(index);
                                }
                                break;
                            }
                        }
                    }
                    usersObj.users = usersList.ToArray<User>(); // Converts the list to a User object array
                    jsonUser = JsonConvert.SerializeObject(usersObj, Formatting.Indented); // Converts object to JSON string
                    File.WriteAllText(usersPath, jsonUser); // Writes JSON data to the file

                    coursesList.Remove(itemToRemove);
                    courseObj.courses = coursesList.ToArray<Course>(); // Converts the list to a User object array
                    json = JsonConvert.SerializeObject(courseObj, Formatting.Indented); // Converts object to JSON string
                    File.WriteAllText(coursesPath, json); // Writes JSON data to the file
                    return "Course Removed successfully";
                }
            }
            return "Course not found";
        }

        public List<string> viewMyCourses(string username)
        {
            string usersPath = HttpRuntime.AppDomainAppPath + "\\users_list.json";
            List<User> usersList = new List<User>();
            UsersRootObject usersObj = new UsersRootObject(); // Object of user
            string jsonUserData = File.ReadAllText(usersPath);
            //string jsonUser;

            List<string> courses = new List<string>();

            usersObj = JsonConvert.DeserializeObject<UsersRootObject>(jsonUserData);
            usersList = usersObj.users.ToList<User>();

            foreach (User user in usersList)
            {
                if (user.StudentName == username)
                {
                    foreach(string course in user.StudentCourses)
                    {
                        courses.Add(course);
                    }
                    return courses;
                }
            }
            return null;
        }

        public List<string> viewAllCourses(string username)
        {
            string usersPath = HttpRuntime.AppDomainAppPath + "\\courses_list.json";
            CourseRootObject courseObj = new CourseRootObject();
            List<Course> coursesList = new List<Course>();
            string jsonCourseData = File.ReadAllText(usersPath);
            //string jsonUser;

            List<string> courses = new List<string>();

            courseObj = JsonConvert.DeserializeObject<CourseRootObject>(jsonCourseData);

            if (courseObj.courses != null)
            {
                coursesList = courseObj.courses.ToList<Course>();
                foreach (Course course in coursesList)
                {
                    courses.Add(course.Name);
                }
                return courses;
            }
            return null;
        }

        public string createAccount(string StudentName, string password)
        {
            User newUser = new User(); // User object for new user
            UsersRootObject usersObj = new UsersRootObject(); // Object of user
            List<User> usersList = new List<User>(); // List of users to read in existing data and add new users
            string json; // for the final JSON formatted list of users
            Boolean exists = false; // boolean value to check if the StudentName exists

            string path = HttpRuntime.AppDomainAppPath + "\\users_list.json"; // File path to user credentials

            try
            {
                string jsonData = File.ReadAllText(path); // reads in the JSON file into a string

                usersObj = JsonConvert.DeserializeObject<UsersRootObject>(jsonData); // transfers jsonData to the usersObj

                if (usersObj.users != null) // makes sure that there is at least one existing user to iterate through accounts
                {
                    usersList = usersObj.users.ToList<User>(); // transfers users to a List<User>

                    foreach (User user in usersList) // iterates through the users
                    {
                        if (user.StudentName == StudentName) // checks if the StudentName already exists
                        {
                            exists = true;
                        }
                    }
                }

                if (!exists) // If StudentName doesn't already exist
                {
                    newUser.StudentName = StudentName;
                    newUser.Password = password;
                    newUser.StudentCourses = new List<string>();

                    //newUser.StudentCourses = new string[];
                    usersList.Add(newUser); // adds the new user to the user list

                    usersObj.users = usersList.ToArray<User>(); // Converts the list to a User object array
                    json = JsonConvert.SerializeObject(usersObj, Newtonsoft.Json.Formatting.Indented); // Converts object to JSON string
                    File.WriteAllText(path, json); // Writes JSON data to the file
                }
            }
            finally
            {

            }
            return "success";
        }

        public class Course
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public Int32 seats { get; set; }
            public List<string> CourseStudents { get; set; }
        }

        public class CourseRootObject
        {
            public Course[] courses { get; set; }
        }

        public class UsersRootObject
        {
            public User[] users { get; set; } // Array of users
        }

        // User class object
        public class User
        {
            public string StudentName { get; set; }
            public string Password { get; set; }
            public List<string> StudentCourses { get; set; }
        }

    }
}
