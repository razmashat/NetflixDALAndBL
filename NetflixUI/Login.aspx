<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NetflixUI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <asp:Label ID="usernameLabel" runat="server" Text="username:"></asp:Label>
   



    <asp:TextBox ID="usernameTextbox" runat="server" style="margin-left: 12px" Width="134px"></asp:TextBox>
    <br />
    <asp:Label ID="passwordLabel" runat="server" Text="password:"></asp:Label>
   



&nbsp;<asp:TextBox ID="passwordTextbox" runat="server" style="margin-left: 9px" Width="129px"></asp:TextBox>
&nbsp;<br />
    <br />
    <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
&nbsp;
   



</asp:Content>
