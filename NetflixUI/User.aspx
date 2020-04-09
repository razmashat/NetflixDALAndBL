<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="NetflixUI.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="PaymentInfo" runat="server" Text="Payment Info:"></asp:Label>
    <br />
    <br />
    <asp:Label ID="PaymentID" runat="server" Text="Payment ID:"></asp:Label>
     <br />
    <br />
    <asp:Label ID="PaymentCard" runat="server" Text="Payment Card:"></asp:Label>
     <br />
    <br />
    <asp:Label ID="PaymentAmount" runat="server" Text="Payment Amount:"></asp:Label>
      <br />
    <br />
    <asp:Label ID="PayerName" runat="server" Text="Payment Name:"></asp:Label>
     <br />
    <br />
    <asp:Label ID="UserInfo" runat="server" Text="My Details:"></asp:Label>
      <br />
    <br />
    <asp:Label ID="username" runat="server" Text="username:">
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="must have username" ControlToValidate="NewUsername" EnableClientScript="False"></asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="invalid username" ControlToValidate="NewUsername" ValidationExpression="[aA-zZ]{1,10}" EnableClientScript="False"></asp:RegularExpressionValidator>
      <br />
    <br />
    <asp:Label ID="password" runat="server" Text="password:"></asp:Label>&nbsp;&nbsp; <asp:TextBox ID="NewPass" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="must have passowrd" ControlToValidate="NewPass" EnableClientScript="False"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="password must conatin 1 lower case latter 1 number and 1 specail character" ValidationExpression="((?=.*\d)(?=.*[a-z])(?=.*[\W]).{8,20})" ControlToValidate="NewPass" EnableClientScript="False"></asp:RegularExpressionValidator>

    

      <br />
    <br />
    <asp:Label ID="Subscription" runat="server" Text="Subscription:"></asp:Label>
      <br />
    <br />
    <asp:Label ID="email" runat="server" Text="email:"></asp:Label>&nbsp;&nbsp; <asp:TextBox ID="NewEmail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="must have email!" ControlToValidate="NewEmail" EnableClientScript="False"></asp:RequiredFieldValidator> <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="invalid email addres" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="NewEmail" EnableClientScript="False"></asp:RegularExpressionValidator>
      <br />
    <br />
    <asp:Button ID="UpdateButton" runat="server" Text="Update Details" OnClick="UpdateButton_Click" />

   




</asp:Content>
