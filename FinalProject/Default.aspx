<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FinalProject._Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Online course portal</h3> <br>
    <asp:Button ID="MemReg" runat="server" Text="MemberRegistration" OnClick="MemReg_Click" />
    

    <asp:Button ID="MemberPage" runat="server" OnClick="MemberPage_Click" Text="Member Page" /> <br>
    <asp:Button ID="StaffReg" runat="server" Text="Staff Registration" OnClick="StaffReg_Click" />
    <asp:Button ID="StaffPage" runat="server" Text="Staff Page" OnClick="StaffPage_Click" />
    

<asp:Label ID="AccessRequest" runat="server" Text="Label"></asp:Label>
<asp:Label ID="LabelStartTime" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="TryIt page for Tanmay's services" />
</asp:Content>
