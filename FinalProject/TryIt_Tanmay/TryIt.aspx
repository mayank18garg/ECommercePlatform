<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TryIt.aspx.cs" Inherits="FinalProject.TryIt_Tanmay.TryIt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Try It Page for Tanmay Jena&#39;s services:</p>
    <p>
        1. Add a course :
    </p>
    <p>
        Enter subject name :
        <asp:TextBox ID="TextBox1" runat="server" Width="399px"></asp:TextBox>
    </p>
    <p>
        Enter subject code:<asp:TextBox ID="TextBox2" runat="server" Width="408px"></asp:TextBox>
    </p>
    <p>
        Enter number of seats:<asp:TextBox ID="TextBox3" runat="server" Width="390px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Course to Database" />
&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        2. Delete a course:</p>
    <p>
        Enter the subject code that you want to delete(Eg. CSE 445):
        <asp:TextBox ID="TextBox4" runat="server" Width="386px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete Course" />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        3. Register a course for the student:</p>
    <p>
        Enter the course code to register for the student. Enter a 3 letter course code followed by a space and 3 digit subject No. (Eg. CSE 445)</p>
    <p>
        <asp:TextBox ID="TextBox5" runat="server" Width="261px"></asp:TextBox>
    </p>
    <p>
        Enter the student username for which to register the course(Eg. Mayank,Tanmay). The username will be checked in the list if it exists or not. Please enter the names in the example to test the service.</p>
    <p>
        <asp:TextBox ID="TextBox6" runat="server" Width="260px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Register course for this student" />
&nbsp;<asp:Label ID="Label3" runat="server"></asp:Label>
    </p>
</asp:Content>
