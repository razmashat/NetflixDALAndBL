<%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="Series.aspx.cs" Inherits="NetflixUI.Series" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:label ID="name" runat="server" text="Label" ForeColor="White"></asp:label>



    <br />
    <br />
    <asp:Image ID="SeriesPoster" runat="server" Width="300" Height="400" BorderStyle="Outset" BorderWidth="5"  BorderColor="GrayText"/>
    <br />
    <br />
    <asp:label ID="desc" runat="server" text="des" ForeColor="White"></asp:label>
    <br />
    <asp:dropdownlist runat="server" ID="drop" OnSelectedIndexChanged="drop_SelectedIndexChanged" AutoPostBack="true"></asp:dropdownlist>
    <br />
    <br />
    <asp:button runat="server" text="add to your account" id="add" OnClick="add_Click" CssClass="btn2"/>





    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server"  OnRowCommand="GridView1_RowCommand" OnDataBound="GridView1_DataBound" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" BorderColor="Red" BorderWidth="1" CellPadding="3">
        <Columns>
               <asp:BoundField HeaderText="Episode Name" DataField="episodeName" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White"/>
               <asp:BoundField HeaderText="Episode Length" DataField="episodeLength" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White"/>
               <asp:BoundField HeaderText="Episode Seasone" DataField="seasonNum" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White"/>
            <asp:BoundField HeaderText="Episode Number" DataField="EpiNum" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White"/>
               <asp:BoundField HeaderText="Avrage Rate" DataField="avgrate" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White"/>
               <asp:ButtonField ButtonType="Button" HeaderText="Rate Episode" Text="Rate" CommandName="Rate" ItemStyle-ForeColor="White" ControlStyle-CssClass="btn2"  HeaderStyle-ForeColor="White"  ControlStyle-ForeColor="Red" />
            <asp:ButtonField ButtonType="Button" Text="Watch" HeaderText="Watch Episode" CommandName="Watch" ItemStyle-ForeColor="White" ControlStyle-CssClass="btn2"  HeaderStyle-ForeColor="White" ControlStyle-ForeColor="Red"/>
               <asp:BoundField HeaderText="EpisodeID" Visible="false" DataField="EpisdeID" HeaderStyle-ForeColor="White" ItemStyle-ForeColor="White"/>
            
         
            
        </Columns>
    </asp:GridView>
     <br />
    <asp:Label ID="Stats" runat="server" Text="Label"></asp:Label>
    <%=error %>





</asp:Content>
