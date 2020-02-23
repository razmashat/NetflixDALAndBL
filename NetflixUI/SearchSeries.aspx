<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="SearchSeries.aspx.cs" Inherits="NetflixUI.SearchSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Enter series name: "></asp:Label>
    <br/>
    <asp:TextBox ID="searchbox" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
</asp:Content>

