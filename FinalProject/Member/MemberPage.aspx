<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberPage.aspx.cs" Inherits="FinalProject.Member.MemberPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>
        
        <asp:Label ID="Label1" runat="server" Text="Hello! In User's World!"></asp:Label></h1> <br>
        <asp:Image ID="Image1" runat="server" />

    <br />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Register a Course" />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="View My Courses" />
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Log Out" />
</asp:Content>
