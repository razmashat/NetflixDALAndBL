<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="MySeries.aspx.cs" Inherits="NetflixUI.MySeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DataList ID="DataList1" runat="server" OnItemDataBound="DataList1_ItemDataBound">


           <ItemTemplate>
            <asp:Label ID="sname" runat="server" Text="Label"></asp:Label>
            </ItemTemplate>

    </asp:DataList>


</asp:Content>
