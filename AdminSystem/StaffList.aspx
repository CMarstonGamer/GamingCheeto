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
        <asp:Label ID="Error" runat="server" style="z-index: 1; left: 16px; top: 455px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 60px; top: 411px; position: absolute" Text="Edit" />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 18px; top: 529px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 85px; top: 530px; position: absolute" Text="Clear" />
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 359px; width: 543px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 16px; top: 410px; position: absolute" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 113px; top: 409px; position: absolute" Text="Delete" />
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 14px; top: 497px; position: absolute" Text="Enter a first name"></asp:Label>
        <asp:TextBox ID="txtEnterName" runat="server" style="z-index: 1; left: 132px; top: 494px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
