<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="NetflixUI.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   

    <asp:Label ID="Label1" runat="server" Text="username:"></asp:Label>
    
    &nbsp;&nbsp; 


    <asp:TextBox ID="username" runat="server"></asp:TextBox>

    




    &nbsp;&nbsp;
    
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="must have username" ControlToValidate="username" EnableClientScript="False"></asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="invalid username" ControlToValidate="username" ValidationExpression="[aA-zZ]{1,10}" EnableClientScript="False"></asp:RegularExpressionValidator>




    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="password:"></asp:Label>

    




&nbsp;&nbsp;
    <asp:TextBox ID="password" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="must have passowrd" ControlToValidate="password" EnableClientScript="False"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="password must conatin 1 lower case latter 1 number and 1 specail character" ValidationExpression="((?=.*\d)(?=.*[a-z])(?=.*[\W]).{8,20})" ControlToValidate="password" EnableClientScript="False"></asp:RegularExpressionValidator>
    <br />
    <br />
&nbsp;<asp:DropDownList ID="subscription" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="must choose subscription" ControlToValidate="subscription" Enabled="False"></asp:RequiredFieldValidator>
    <br />
    
    <br />
    
    
    <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>  &nbsp;&nbsp; <asp:TextBox ID="email" runat="server"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="must have email!" ControlToValidate="email" EnableClientScript="False"></asp:RequiredFieldValidator> <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="invalid email addres" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="email" EnableClientScript="False"></asp:RegularExpressionValidator>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Credit Card Number:"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="CreditCard" runat="server"></asp:TextBox>
    <br />
    <br />
     <asp:Label ID="Label5" runat="server" Text="Owner ID:"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="Owner" runat="server"></asp:TextBox>
    <br />
    <br />
     <asp:Label ID="Label6" runat="server" Text="CVV:"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="CVV" runat="server"></asp:TextBox>
    <br />
    <br />
     <asp:Label ID="Label7" runat="server" Text="Experation Month:"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="ExpMonth" runat="server"></asp:TextBox>
    <br />
    <br />
     <asp:Label ID="Label8" runat="server" Text="Experation Year:"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="ExpYear" runat="server"></asp:TextBox>
    <br />
    <br />
     <asp:Label ID="Label9" runat="server" Text="First Name Of Cardholder:"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
    <br />
    <br />
       <asp:Label ID="Label10" runat="server" Text="Last Name Of Cardholder:"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="submit" runat="server" Text="sign up" OnClick="submit_Click" />

    <%=err %>
</asp:Content>
