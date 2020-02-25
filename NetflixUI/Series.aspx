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
    <asp:dropdownlist runat="server" ID="drop" OnSelectedIndexChanged="drop_SelectedIndexChanged"></asp:dropdownlist>
    <asp:button runat="server" text="add to your account" id="add" OnClick="add_Click" />





    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
     <br />
    <%=error %>





</asp:Content>
