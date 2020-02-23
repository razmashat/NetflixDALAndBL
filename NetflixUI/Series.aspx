<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="Series.aspx.cs" Inherits="NetflixUI.Series" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:label ID="name" runat="server" text="Label"></asp:label>



    <br />
    <br />

    <br />
    <br />
    <asp:label ID="desc" runat="server" text="des"></asp:label>
    <br />
    <asp:dropdownlist runat="server" ID="drop"></asp:dropdownlist>
    <asp:button runat="server" text="add to your account" id="add" OnClick="add_Click" />





    <br />
    <br />
    <br />
    <asp:datalist runat="server" ID="datalist"></asp:datalist>





</asp:Content>
