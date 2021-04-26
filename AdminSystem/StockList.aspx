<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 161px; top: 424px; position: absolute" Text="Delete" />
        <asp:ListBox ID="lstStockCollection" runat="server" style="z-index: 1; left: 20px; top: 56px; position: absolute; height: 339px; width: 448px"></asp:ListBox>
        <asp:Button ID="btnEdit" OnClick="btnEdit_Click" runat="server" style="z-index: 1; left: 90px; top: 423px; position: absolute" Text="Edit" />
        <asp:Button ID="btnAdd" OnClick="btnAdd_Click" runat="server" style="z-index: 1; left: 28px; top: 423px; position: absolute" Text="Add" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 77px; top: 480px; position: absolute; width: 62px"></asp:Label>
    </form>
</body>
</html>
