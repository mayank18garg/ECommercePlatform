<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberLogin.aspx.cs" Inherits="FinalProject.Member.MemberLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center><h2><asp:Label ID="Label1" runat="server" Text="MemberLoginPAGE"></asp:Label></h2><br>
        
        <asp:Label ID="Label5" runat="server" Text=""></asp:Label><br><br>


        <asp:Label ID="Label2" runat="server" Text="Login"></asp:Label><br><br>

        <asp:Label ID="Label3" runat="server" Text="Enter the UserName"></asp:Label><br>


        <asp:TextBox ID="UserInput" runat="server"></asp:TextBox><br><br>


        <asp:Label ID="Label4" runat="server" Text="Enter the Password"></asp:Label><br>

        <asp:TextBox ID="PasswordInput" runat="server"></asp:TextBox><br>

        <asp:Button ID="Login" runat="server" OnClick="Login_Click" Text="SignIn" /><br>

        <asp:Label ID="Error" runat="server"></asp:Label>

    </center>


</asp:Content>
