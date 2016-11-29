<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebServices.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="grid" runat="server">

        </asp:GridView>
        <br/>
        <asp:Label ID="binary" runat="server"></asp:Label>
        <br/>
        <asp:Label ID="listen" runat="server"></asp:Label>
        <br/>
        <asp:Label ID="closely" runat="server"></asp:Label>
        <br/>
    </div>
    </form>
</body>
</html>
