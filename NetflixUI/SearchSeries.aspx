<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="SearchSeries.aspx.cs" Inherits="NetflixUI.SearchSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Enter series name: "></asp:Label>
    <br/>
    <asp:TextBox ID="searchbox" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />

    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="All Series:"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:ButtonField ButtonType="Button" Text="Details" />
        </Columns>
    </asp:GridView>
</asp:Content>

