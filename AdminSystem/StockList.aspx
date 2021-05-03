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
        <asp:Button ID="btnDelete" OnClick="btnDelete_Click" runat="server" style="z-index: 1; left: 161px; top: 424px; position: absolute" Text="Delete" />
        <asp:Button ID="btnApply" OnClick="btnApply_Click" runat="server" style="z-index: 1; left: 516px; top: 105px; position: absolute; right: 503px" Text="Apply" />
        <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" style="z-index: 1; left: 715px; top: 103px; position: absolute" Text="Clear" />
        <asp:Button ID="btnClearPrice" OnClick="btnClearPrice_Click" runat="server" style="z-index: 1; left: 715px; top: 248px; position: absolute" Text="Clear" />
        <asp:ListBox ID="lstStockCollection" runat="server" style="z-index: 1; left: 20px; top: 56px; position: absolute; height: 339px; width: 448px"></asp:ListBox>
        <asp:Button ID="btnEdit" OnClick="btnEdit_Click" runat="server" style="z-index: 1; left: 90px; top: 423px; position: absolute" Text="Edit" />
        <asp:Button ID="btnAdd" OnClick="btnAdd_Click" runat="server" style="z-index: 1; left: 28px; top: 423px; position: absolute" Text="Add" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 345px; top: 427px; position: absolute; width: 62px"></asp:Label>
        <asp:Label ID="lblGameTitle" runat="server" style="z-index: 1; left: 486px; top: 66px; position: absolute" Text="Enter GameTitle"></asp:Label>
        <asp:TextBox ID="txtGameTitle" runat="server" style="z-index: 1; left: 676px; top: 64px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 482px; top: 199px; position: absolute" Text="Enter Maximum Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 678px; top: 199px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyPrice" OnClick="btnApplyPrice_Click" runat="server" style="z-index: 1; left: 517px; top: 248px; position: absolute" Text="Apply" />
    </form>
</body>
</html>
