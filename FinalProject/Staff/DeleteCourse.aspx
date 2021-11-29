<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteCourse.aspx.cs" Inherits="FinalProject.Staff.DeleteCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Delete a Course</p>
    <p>
        Enter the subject code that you want to delete(Eg. CSE 445):
        <asp:TextBox ID="TextBox1" runat="server" Width="386px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete Course" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button2" runat="server" Text="Log Out" />
    </p>
</asp:Content>
