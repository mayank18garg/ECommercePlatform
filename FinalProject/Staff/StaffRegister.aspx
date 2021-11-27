<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StaffRegister.aspx.cs" Inherits="FinalProject.Staff.StaffRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
    <h2><asp:Label ID="Label1" runat="server" Text="Staff Registration"></asp:Label></h2><br>


     

    <asp:Label ID="Label2" runat="server" Text="Enter the UserName"></asp:Label><br>

    <asp:TextBox ID="UserInput" runat="server"></asp:TextBox><br>


    <asp:Label ID="Label3" runat="server" Text="Enter the Password"></asp:Label><br>


    <asp:TextBox ID="PasswordInput" runat="server"></asp:TextBox><br>
    <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click" /> <br>
    

    <asp:Label ID="Error" runat="server"></asp:Label>
        </center>
</asp:Content>
