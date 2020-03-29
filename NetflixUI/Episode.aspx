<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Episode.aspx.cs" Inherits="NetflixUI.Episode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="EpiName" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Time" runat="server" Text="Label"></asp:Label>


            <br />
            <br />


            <asp:Label ID="AvgRate" runat="server" Text="Label"></asp:Label>
                 <br />
            <br />
            <asp:Label ID="MyRate" runat="server" Text="Label"></asp:Label>
                 <br />
            <br />

            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
               <br />
            <br />
            <asp:Button ID="Rate" runat="server" Text="Rate This Episode" OnClick="Rate_Click" />
               <br />
            <br />
              <asp:Button ID="Watch" runat="server" Text="Wtach This Episode" OnClick="Watch_Click" />

        </div>
    </form>
</body>
</html>
