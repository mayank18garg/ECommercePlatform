<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StaffPage.aspx.cs" Inherits="FinalProject.Staff.StaffPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2> Welcome to thw Staff World! </h2>
    <p> 
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add a Course" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete a Course" />
    </p>
</asp:Content>
