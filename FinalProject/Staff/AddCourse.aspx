<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCourse.aspx.cs" Inherits="FinalProject.Staff.AddCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Add a Course</p>
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
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Log Out" />
    </p>
</asp:Content>
