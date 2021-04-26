<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 84px; top: 118px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 235px; position: absolute; top: 116px" Text="No" />
        <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 63px; top: 67px; position: absolute" Text="Are sure you want to delete this record?"></asp:Label>
    </form>
</body>
</html>
