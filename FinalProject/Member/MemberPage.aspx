<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberPage.aspx.cs" Inherits="FinalProject.Member.MemberPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1><asp:Label ID="Label1" runat="server" Text="Hello! In User's World!"></asp:Label></h1>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Available Courses" />
    </p>

</asp:Content>
