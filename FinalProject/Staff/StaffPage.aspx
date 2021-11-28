<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StaffPage.aspx.cs" Inherits="FinalProject.Staff.StaffPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2> Welcome to thw Staff World! </h2>
    <p> 
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="AddCourse" />
    </p>
</asp:Content>
