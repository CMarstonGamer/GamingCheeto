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
        <asp:Button ID="btnApply" OnClick="btnApply_Click" runat="server" style="z-index: 1; left: 515px; top: 105px; position: absolute; right: 503px" Text="Apply" />
        <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" style="z-index: 1; left: 715px; top: 105px; position: absolute" Text="Clear" />
        <asp:Button ID="btnApplyDate" OnClick="btnApplyDate_Click" runat="server" style="z-index: 1; left: 515px; top: 554px; position: absolute" Text="Apply" />
        <asp:ListBox ID="lstStockCollection" runat="server" style="z-index: 1; left: 20px; top: 56px; position: absolute; height: 339px; width: 448px"></asp:ListBox>
        <asp:Button ID="btnEdit" OnClick="btnEdit_Click" runat="server" style="z-index: 1; left: 90px; top: 423px; position: absolute" Text="Edit" />
        <asp:Button ID="btnAdd" OnClick="btnAdd_Click" runat="server" style="z-index: 1; left: 28px; top: 423px; position: absolute" Text="Add" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 345px; top: 427px; position: absolute; width: 62px"></asp:Label>
        <asp:Label ID="lblGameTitle" runat="server" style="z-index: 1; left: 486px; top: 66px; position: absolute" Text="Enter GameTitle"></asp:Label>
        <asp:TextBox ID="txtGameTitle" runat="server" style="z-index: 1; left: 680px; top: 64px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 482px; top: 199px; position: absolute" Text="Enter Maximum Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 680px; top: 199px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyPrice" OnClick="btnApplyPrice_Click" runat="server" style="z-index: 1; left: 515px; top: 250px; position: absolute" Text="Apply" />
        <asp:Button ID="btnApplyInStock" runat="server" OnClick="btnApplyInStock_Click" style="z-index: 1; left: 690px; top: 315px; position: absolute" Text="Apply" />
        <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 495px; top: 318px; position: absolute" Text="Is the game in stock?" />
        <asp:Label ID="lblStockQuantity" runat="server" style="z-index: 1; left: 492px; top: 387px; position: absolute" Text="Enter Stock Quantity"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server" style="z-index: 1; left: 680px; top: 385px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyStockQ" OnClick="btnApplyStockQ_Click" runat="server" style="z-index: 1; left: 515px; top: 435px; position: absolute" Text="Apply" />
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 477px; top: 507px; position: absolute" Text="Enter Maximum Release Date"></asp:Label>
        <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 682px; top: 506px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
