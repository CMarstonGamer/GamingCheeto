<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 114px; top: 514px; position: absolute" Text="Delete" />
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 488px; width: 507px"></asp:ListBox>
        </div>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 63px; top: 514px; position: absolute" Text="Edit" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 12px; top: 514px; position: absolute" Text="Add" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 564px; position: absolute" Text="Label"></asp:Label>
    </form>
</body>
</html>
