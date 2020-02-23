<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="MySeries.aspx.cs" Inherits="NetflixUI.MySeries" enableEventValidation="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DataList ID="DataList1" runat="server" OnItemDataBound="DataList1_ItemDataBound" OnItemCommand="DataList1_ItemCommand">


           <ItemTemplate>
            <asp:Label ID="sname" runat="server" Text="Label"></asp:Label>
               <asp:Label ID="sid" runat="server" Text="Label" Visible="false"></asp:Label>
               <br />
               <asp:Button ID="Button1" runat="server" Text="Button" />
            </ItemTemplate>

    </asp:DataList>


</asp:Content>
