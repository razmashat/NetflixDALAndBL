<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="NetflixUI.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <asp:Label ID="Label1" runat="server" Text="username:"></asp:Label>
    

    &nbsp;&nbsp; 


    <asp:TextBox ID="username" runat="server"></asp:TextBox>

    




    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="password:"></asp:Label>

    




&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
&nbsp;<asp:DropDownList ID="subscription" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    <asp:ListItem Text="1" Value="1"></asp:ListItem>
     <asp:ListItem Text="2" Value="2"></asp:ListItem>
     <asp:ListItem Text="3" Value="3"></asp:ListItem>
     <asp:ListItem Text="4" Value="4"></asp:ListItem>
     <asp:ListItem Text="5" Value="5"></asp:ListItem>
    </asp:DropDownList>

    <br />
    <br />

    <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>  &nbsp;&nbsp; <asp:TextBox ID="email" runat="server"></asp:TextBox>



</asp:Content>
