<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Error" runat="server" style="z-index: 1; left: 27px; top: 563px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 74px; top: 526px; position: absolute" Text="Edit" />
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 482px; width: 543px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 28px; top: 525px; position: absolute" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 122px; top: 525px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
