<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="NetflixUI.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Label ID="Label1" runat="server" Text="my users:" ForeColor="White"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderColor="Red" BorderWidth="1">
        <Columns>
            <asp:BoundField HeaderText="Username" DataField="Username" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White"/>
            <asp:BoundField HeaderText="Email" DataField="Email" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White"/>
            <asp:BoundField HeaderText="Subscription type" DataField="SubType" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White"/>
            <asp:BoundField HeaderText="Series Watched" DataField="SeriesWatched" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White"/>
        </Columns>
    </asp:GridView>
    <br />
     <br />
    <asp:Label ID="Label2" runat="server" Text="my series:" ForeColor="White"></asp:Label>
    <br/>
      <br/>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"  BorderColor="Red" BorderWidth="1">
        <Columns>
            <asp:BoundField HeaderText="Series Name" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White" DataField="SeriesAdmin"/>
            <asp:BoundField HeaderText="Series Description" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White" DataField="description"/>
            <asp:ButtonField ButtonType="Button" Text="Upload Episode" ControlStyle-CssClass="btn2"/>
        </Columns>
    </asp:GridView>
    <br/>
     <br />
     <asp:Label ID="Label3" runat="server" Text="Total Parchu:"  ForeColor="White"></asp:Label>
    <br/>
     <br />
    
    <asp:GridView ID="GridView3" runat="server" ForeColor="White" AutoGenerateColumns="False"  BorderColor="Red" BorderWidth="1px">
        <Columns>
            <asp:BoundField HeaderText="User" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White" DataField="Payee"/>
            <asp:BoundField HeaderText="Transaction ID" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White" DataField="ID"/>
            <asp:BoundField HeaderText="Amount" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White" DataField="Amount"/>
        </Columns>
    </asp:GridView>

</asp:Content>
