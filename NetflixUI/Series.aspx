<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="Series.aspx.cs" Inherits="NetflixUI.Series" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:label ID="name" runat="server" text="Label"></asp:label>



    <br />
    <br />
    <asp:Image ID="SeriesPoster" runat="server" />
    <br />
    <br />
    <asp:label ID="desc" runat="server" text="des"></asp:label>
    <br />
    <asp:dropdownlist runat="server" ID="drop" OnSelectedIndexChanged="drop_SelectedIndexChanged" AutoPostBack="true"></asp:dropdownlist>
    <asp:button runat="server" text="add to your account" id="add" OnClick="add_Click" />





    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server"  OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:ButtonField ButtonType="Button" Text="Details" />
        </Columns>
    </asp:GridView>
     <br />
    <asp:Label ID="Stats" runat="server" Text="Label"></asp:Label>
    <%=error %>





</asp:Content>
