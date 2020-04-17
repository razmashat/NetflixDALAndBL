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
        <asp:DataList ID="DataList1" runat="server" OnItemDataBound="DataList1_ItemDataBound" OnItemCommand="DataList1_ItemCommand" Width="487px" RepeatDirection="Horizontal" CellPadding="50" RepeatColumns="3">


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
    <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:ButtonField ButtonType="Button" Text="Details" />
        </Columns>
    </asp:GridView>
</asp:Content>

