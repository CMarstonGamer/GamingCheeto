<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 115px; top: 514px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 16px; top: 15px; position: absolute; height: 488px; width: 507px"></asp:ListBox>
        </div>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 66px; top: 514px; position: absolute" Text="Edit" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 16px; top: 514px; position: absolute" Text="Add" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 650px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtFilterCustomerName" runat="server" style="z-index: 1; left: 209px; top: 567px; position: absolute; width: 282px"></asp:TextBox>
        <asp:Label ID="lblEnterACustomerName" runat="server" style="z-index: 1; left: 16px; top: 566px; position: absolute" Text="Enter a Customer Name"></asp:Label>
        <asp:Button ID="btnApply" runat="server" height="29px" OnClick="btnApply_Click" style="z-index: 1; left: 16px; top: 597px; position: absolute" Text="Apply" width="57px" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 81px; top: 597px; position: absolute; height: 29px" Text="Clear" />
    </form>
</body>
</html>
