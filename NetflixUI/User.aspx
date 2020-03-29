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



</asp:Content>
