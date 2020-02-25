<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="NetflixUI.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Label ID="Label1" runat="server" Text="my users:"></asp:Label>
    <br/>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:Label ID="Label2" runat="server" Text="my series:"></asp:Label>
    <br/>
    <asp:GridView ID="GridView2" runat="server"></asp:GridView>

</asp:Content>
