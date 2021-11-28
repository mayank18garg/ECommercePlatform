using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;

namespace service1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string addUser(string User, string password, int role);

        [OperationContract]
        string searchUser(string User, string password, int role);

        [OperationContract]
        string addCourse(string Name, string Code, Int32 seats);

        [OperationContract]
        string registercourse(string courseCode, string userName);

        [OperationContract]
        string deleteCourse(string Code);

        [OperationContract]
        List<string> viewCourses(string username);

        [OperationContract]
        string createAccount(string StudentName, string password);

    }
    
}
