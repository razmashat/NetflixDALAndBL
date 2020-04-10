﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="MySeries.aspx.cs" Inherits="NetflixUI.MySeries" enableEventValidation="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DataList ID="DataList1" runat="server" OnItemDataBound="DataList1_ItemDataBound" OnItemCommand="DataList1_ItemCommand" Width="487px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" RepeatDirection="Horizontal" CellPadding="50">


           <ItemTemplate>
               <asp:Image ID="sposter" runat="server" Width="200" Height="300" BorderStyle="Outset" BorderWidth="1"  BorderColor="GrayText"/>

               <br />
               <asp:Label ID="sid" runat="server" Text="Label" Visible="false"></asp:Label>
               <br />
               <asp:Button ID="sname" runat="server" Text="Button" ForeColor="Red" Font-Size="Large" CssClass="btn2" />
                 <br />
               <br />
               <asp:Label ID="sdesc" runat="server" Text="Label" Visible="true" ForeColor="White" Font-Size="Large" BorderStyle="Outset" BorderWidth="1" BorderColor="GrayText" CssClass="LabelPaddingStyle"></asp:Label>
                <br />

            </ItemTemplate>

    </asp:DataList>


</asp:Content>
