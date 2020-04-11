<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="NetflixUI.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   

    <asp:Label ID="Label1" runat="server" Text="username:" ForeColor="White"></asp:Label>
    
    &nbsp;&nbsp; 


    <asp:TextBox ID="username" runat="server" CssClass="form-control" BorderColor="Red" style="margin-left: 0px" Width="207px" ></asp:TextBox>

    




    &nbsp;&nbsp;
    
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="must have username" ControlToValidate="username" EnableClientScript="False"></asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="invalid username" ControlToValidate="username" ValidationExpression="[aA-zZ]{1,10}" EnableClientScript="False"></asp:RegularExpressionValidator>




    <br />
    <asp:Label ID="Label2" runat="server" Text="password:" ForeColor="White"></asp:Label>

    




&nbsp;&nbsp;
    <asp:TextBox ID="password" runat="server" CssClass="form-control" BorderColor="Red" style="margin-left: 0px" Width="204px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="must have passowrd" ControlToValidate="password" EnableClientScript="False"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="password must conatin 1 lower case latter 1 number and 1 specail character" ValidationExpression="((?=.*\d)(?=.*[a-z])(?=.*[\W]).{8,20})" ControlToValidate="password" EnableClientScript="False"></asp:RegularExpressionValidator>
    <br />
&nbsp;<asp:DropDownList ID="subscription" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="must choose subscription" ControlToValidate="subscription" Enabled="False"></asp:RequiredFieldValidator>
    <br />
    
    
    
    <asp:Label ID="Label4" runat="server" Text="Email" ForeColor="White"></asp:Label>  &nbsp;&nbsp; <asp:TextBox ID="email" runat="server" CssClass="form-control" BorderColor="Red" style="margin-left: 0px" Width="205px"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="must have email!" ControlToValidate="email" EnableClientScript="False"></asp:RequiredFieldValidator> <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="invalid email addres" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="email" EnableClientScript="False"></asp:RegularExpressionValidator>
    <br />

    <asp:Label ID="Label3" runat="server" Text="Credit Card Number:" ForeColor="White"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="CreditCard" runat="server" CssClass="form-control" BorderColor="Red" style="margin-left: 0px" Width="206px"></asp:TextBox>
    <br />

     <asp:Label ID="Label5" runat="server" Text="Owner ID:" ForeColor="White"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="Owner" runat="server" CssClass="form-control" BorderColor="Red" style="margin-left: 0px" Width="205px"></asp:TextBox>
    <br />

     <asp:Label ID="Label6" runat="server" Text="CVV:" ForeColor="White"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="CVV" runat="server" CssClass="form-control" BorderColor="Red" style="margin-left: 0px" Width="204px"></asp:TextBox>
    <br />

     <asp:Label ID="Label7" runat="server" Text="Experation Month:" ForeColor="White"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="ExpMonth" runat="server" CssClass="form-control" BorderColor="Red" style="margin-left: 0px" Width="204px"></asp:TextBox>


     <asp:Label ID="Label8" runat="server" Text="Experation Year:" ForeColor="White"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="ExpYear" runat="server" CssClass="form-control" BorderColor="Red" style="margin-left: 0px" Width="205px"></asp:TextBox>

    <br />
     <asp:Label ID="Label9" runat="server" Text="First Name Of Cardholder:" ForeColor="White"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="FirstName" runat="server" CssClass="form-control" BorderColor="Red" style="margin-left: 0px" Width="205px"></asp:TextBox>

    <br />
       <asp:Label ID="Label10" runat="server" Text="Last Name Of Cardholder:" ForeColor="White"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="LastName" runat="server" CssClass="form-control" BorderColor="Red" style="margin-left: 0px" Width="204px"></asp:TextBox>
 
    <br />
    <asp:Button ID="submit" runat="server" Text="sign up" OnClick="submit_Click" />

    <%=err %>
</asp:Content>
