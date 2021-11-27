<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberRegister.aspx.cs" Inherits="MemberRegister" %>
<%@ Register TagPrefix="myControl" TagName="ImgVerifier" src="ImgVerifierRegister.ascx"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     

    <h2><asp:Label ID="Label1" runat="server" Text="User Registration"></asp:Label></h2><br>


     

    <asp:Label ID="Label2" runat="server" Text="Enter the UserName"></asp:Label><br>

    <asp:TextBox ID="UserInput" runat="server"></asp:TextBox><br>


    <asp:Label ID="Label3" runat="server" Text="Enter the Password"></asp:Label><br>


    <asp:TextBox ID="PasswordInput" runat="server"></asp:TextBox><br><br>

    <myControl:ImgVerifier ID="Test" runat="Server">
</myControl:ImgVerifier>
   &nbsp;
      <asp:TextBox ID="textInput1" runat="server" Height="21px" Width="100px" BorderColor="#999999"></asp:TextBox> 
     <asp:RequiredFieldValidator ForeColor="red"  runat="server" id="RequiredFieldValidator3" controltovalidate="textInput1" errormessage="Please enter the String!" />
     <br />

    <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click" /> <br>
    

    <asp:Label ID="Error" runat="server"></asp:Label>
</asp:Content>
