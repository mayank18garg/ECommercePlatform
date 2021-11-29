﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUser", ReplyAction="http://tempuri.org/IService1/addUserResponse")]
        string addUser(string User, string password, int role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUser", ReplyAction="http://tempuri.org/IService1/addUserResponse")]
        System.Threading.Tasks.Task<string> addUserAsync(string User, string password, int role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/searchUser", ReplyAction="http://tempuri.org/IService1/searchUserResponse")]
        string searchUser(string User, string password, int role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/searchUser", ReplyAction="http://tempuri.org/IService1/searchUserResponse")]
        System.Threading.Tasks.Task<string> searchUserAsync(string User, string password, int role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addCourse", ReplyAction="http://tempuri.org/IService1/addCourseResponse")]
        string addCourse(string Name, string Code, int seats);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addCourse", ReplyAction="http://tempuri.org/IService1/addCourseResponse")]
        System.Threading.Tasks.Task<string> addCourseAsync(string Name, string Code, int seats);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/registercourse", ReplyAction="http://tempuri.org/IService1/registercourseResponse")]
        string registercourse(string courseCode, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/registercourse", ReplyAction="http://tempuri.org/IService1/registercourseResponse")]
        System.Threading.Tasks.Task<string> registercourseAsync(string courseCode, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteCourse", ReplyAction="http://tempuri.org/IService1/deleteCourseResponse")]
        string deleteCourse(string Code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteCourse", ReplyAction="http://tempuri.org/IService1/deleteCourseResponse")]
        System.Threading.Tasks.Task<string> deleteCourseAsync(string Code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewMyCourses", ReplyAction="http://tempuri.org/IService1/viewMyCoursesResponse")]
        string[] viewMyCourses(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewMyCourses", ReplyAction="http://tempuri.org/IService1/viewMyCoursesResponse")]
        System.Threading.Tasks.Task<string[]> viewMyCoursesAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createAccount", ReplyAction="http://tempuri.org/IService1/createAccountResponse")]
        string createAccount(string StudentName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createAccount", ReplyAction="http://tempuri.org/IService1/createAccountResponse")]
        System.Threading.Tasks.Task<string> createAccountAsync(string StudentName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewAllCourses", ReplyAction="http://tempuri.org/IService1/viewAllCoursesResponse")]
        string[] viewAllCourses(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewAllCourses", ReplyAction="http://tempuri.org/IService1/viewAllCoursesResponse")]
        System.Threading.Tasks.Task<string[]> viewAllCoursesAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : FinalProject.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<FinalProject.ServiceReference1.IService1>, FinalProject.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string addUser(string User, string password, int role) {
            return base.Channel.addUser(User, password, role);
        }
        
        public System.Threading.Tasks.Task<string> addUserAsync(string User, string password, int role) {
            return base.Channel.addUserAsync(User, password, role);
        }
        
        public string searchUser(string User, string password, int role) {
            return base.Channel.searchUser(User, password, role);
        }
        
        public System.Threading.Tasks.Task<string> searchUserAsync(string User, string password, int role) {
            return base.Channel.searchUserAsync(User, password, role);
        }
        
        public string addCourse(string Name, string Code, int seats) {
            return base.Channel.addCourse(Name, Code, seats);
        }
        
        public System.Threading.Tasks.Task<string> addCourseAsync(string Name, string Code, int seats) {
            return base.Channel.addCourseAsync(Name, Code, seats);
        }
        
        public string registercourse(string courseCode, string userName) {
            return base.Channel.registercourse(courseCode, userName);
        }
        
        public System.Threading.Tasks.Task<string> registercourseAsync(string courseCode, string userName) {
            return base.Channel.registercourseAsync(courseCode, userName);
        }
        
        public string deleteCourse(string Code) {
            return base.Channel.deleteCourse(Code);
        }
        
        public System.Threading.Tasks.Task<string> deleteCourseAsync(string Code) {
            return base.Channel.deleteCourseAsync(Code);
        }
        
        public string[] viewMyCourses(string username) {
            return base.Channel.viewMyCourses(username);
        }
        
        public System.Threading.Tasks.Task<string[]> viewMyCoursesAsync(string username) {
            return base.Channel.viewMyCoursesAsync(username);
        }
        
        public string createAccount(string StudentName, string password) {
            return base.Channel.createAccount(StudentName, password);
        }
        
        public System.Threading.Tasks.Task<string> createAccountAsync(string StudentName, string password) {
            return base.Channel.createAccountAsync(StudentName, password);
        }
        
        public string[] viewAllCourses(string username) {
            return base.Channel.viewAllCourses(username);
        }
        
        public System.Threading.Tasks.Task<string[]> viewAllCoursesAsync(string username) {
            return base.Channel.viewAllCoursesAsync(username);
        }
    }
}
