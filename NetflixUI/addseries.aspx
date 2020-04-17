 <%@ Page Title="" Language="C#" MasterPageFile="~/MastePage.Master" AutoEventWireup="true" CodeBehind="addseries.aspx.cs" Inherits="NetflixUI.addseries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Label ID="Label1" runat="server" Text="series name:" ForeColor="White"></asp:Label> &nbsp; <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"  style="margin-left: 12px" Width="231px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="must enter series name" ControlToValidate="TextBox1" BorderStyle="Outset" EnableClientScript="False"></asp:RequiredFieldValidator>
    &nbsp;<br/>
    <br/>
    <asp:Label ID="Label2" runat="server" Text="description:" ForeColor="White"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"  style="margin-left: 12px" Width="231px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="must enter descreption" ControlToValidate="TextBox2" EnableClientScript="False"></asp:RequiredFieldValidator>
    <br />
    <br/>
    <asp:Label ID="Label3" runat="server" Text="Poster url:" ForeColor="White"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" style="margin-left: 12px" Width="231px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="must enter poster url" ControlToValidate="TextBox3" EnableClientScript="False"></asp:RequiredFieldValidator>
    <br />
    <br/>
    <asp:Label ID="Label4" runat="server" Text="Genre:" ForeColor="White"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Action</asp:ListItem>
        <asp:ListItem>Comedy</asp:ListItem>
    </asp:DropDownList>
    <br/>
    <br/>
    <asp:Button ID="Button1" runat="server" Text="add" OnClick="Button1_Click" ForeColor="Red" CssClass="btn2"/>
    <br/>
    <br/>
    <% =error %>

</asp:Content>
