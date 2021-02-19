<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 14px; top: 49px; position: absolute; height: 22px" Text="StaffId" width="74px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 169px; top: 52px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtfirstName" runat="server" style="z-index: 1; top: 96px; position: absolute; left: 169px"></asp:TextBox>
        <asp:TextBox ID="txtsurname" runat="server" style="z-index: 1; left: 169px; top: 149px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtdateOfBirth" runat="server" style="z-index: 1; left: 169px; top: 261px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtpassword" runat="server" style="z-index: 1; left: 169px; top: 306px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblfirstName" runat="server" style="z-index: 1; left: 14px; top: 99px; position: absolute; " Text="FirstName" width="74px"></asp:Label>
        <asp:Label ID="lblsurname" runat="server" style="z-index: 1; left: 14px; top: 150px; position: absolute; width: 74px;" Text="Surname"></asp:Label>
        <asp:Label ID="lbldateOfBirth" runat="server" style="z-index: 1; left: 14px; top: 263px; position: absolute" Text="DateOfBirth"></asp:Label>
        <asp:Label ID="lblpassword" runat="server" style="z-index: 1; left: 14px; top: 304px; position: absolute" Text="Password" width="74px"></asp:Label>
        <asp:CheckBox ID="chkmanagerOrStaff" runat="server" style="z-index: 1; left: 14px; top: 201px; position: absolute" Text="Manager?" width="74px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 352px; position: absolute" width="74px"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click1" style="z-index: 1; left: 33px; top: 408px; position: absolute" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 116px; top: 408px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
