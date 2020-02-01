<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="NetflixUI.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id ="regform" runat="server">
<div>

    <asp:Label ID="Label1" runat="server" Text="username:"></asp:Label>
    
    &nbsp;&nbsp; 


    <asp:TextBox ID="username" runat="server"></asp:TextBox>

    




    &nbsp;&nbsp;
    
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="must have username" ControlToValidate="username"></asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="invalid username" ControlToValidate="username" ValidationExpression="[aA-zZ]{1,10}"></asp:RegularExpressionValidator>




    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="password:"></asp:Label>

    




&nbsp;&nbsp;
    <asp:TextBox ID="password" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="must have passowrd" ControlToValidate="password"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="password must conatin 1 lower case latter 1 number and 1 specail character" ValidationExpression="((?=.*\d)(?=.*[a-z])(?=.*[\W]).{8,20})"></asp:RegularExpressionValidator>
    <br />
    <br />
&nbsp;<asp:DropDownList ID="subscription" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    <asp:ListItem Text="1" Value="1"></asp:ListItem>
     <asp:ListItem Text="2" Value="2"></asp:ListItem>
     <asp:ListItem Text="3" Value="3"></asp:ListItem>
     <asp:ListItem Text="4" Value="4"></asp:ListItem>
     <asp:ListItem Text="5" Value="5"></asp:ListItem>
    </asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="must choose subscription" ControlToValidate="subscription"></asp:RequiredFieldValidator>
    <br />
    
    <br />
    
    
    <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>  &nbsp;&nbsp; <asp:TextBox ID="email" runat="server"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="must have email!" ControlToValidate="email"></asp:RequiredFieldValidator> <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="invalid email addres" ValidationExpression="eneter in class tommorow" ControlToValidate="email"></asp:RegularExpressionValidator>
        </div>
</form>
    <%=err %>
</asp:Content>
