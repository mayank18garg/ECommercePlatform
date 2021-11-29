<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewAvailableCourses.aspx.cs" Inherits="FinalProject.Member.viewAvailableCourses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Select a Course to register:"></asp:Label>
    </p>
    <p>
    </p>
    <p>
        <asp:ListBox ID="ListBox1" runat="server" Width="359px"></asp:ListBox>
        <br />
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
