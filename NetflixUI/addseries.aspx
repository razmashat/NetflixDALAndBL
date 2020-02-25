<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="addseries.aspx.cs" Inherits="NetflixUI.addseries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Label ID="Label1" runat="server" Text="series name:" ></asp:Label> &nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="must enter series name" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
    <br/>
    <br/>
    <asp:Label ID="Label2" runat="server" Text="description:" ></asp:Label> &nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="must enter descreption" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
    <br/>
    <br/>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Action</asp:ListItem>
        <asp:ListItem>Comedy</asp:ListItem>
    </asp:DropDownList>
    <br/>
    <br/>
    <asp:Button ID="Button1" runat="server" Text="add" OnClick="Button1_Click" />
    <br/>
    <br/>
    <% =error %>

</asp:Content>
