<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 329px; top: 13px; position: absolute" Text="Find" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 332px; position: absolute"></asp:Label>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 22px; top: 17px; position: absolute" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 143px; top: 13px; position: absolute; height: 25px;" width="168px"></asp:TextBox>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 22px; top: 59px; position: absolute" Text="Name"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 143px; top: 55px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 22px; top: 106px; position: absolute" Text="Email"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 143px; top: 102px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:Label ID="lblCustomerPassword" runat="server" style="z-index: 1; left: 22px; top: 151px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtCustomerPassword" runat="server" style="z-index: 1; left: 143px; top: 147px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:Label ID="lblCustomerCardNumber" runat="server" style="z-index: 1; left: 22px; top: 196px; position: absolute" Text="Card Number"></asp:Label>
        <asp:TextBox ID="txtCustomerCardNumber" runat="server" style="z-index: 1; left: 143px; top: 192px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:Label ID="lblCustomerCreationDate" runat="server" style="z-index: 1; left: 22px; top: 243px; position: absolute" Text="Creation Date"></asp:Label>
        <asp:TextBox ID="txtCustomerCreationDate" runat="server" style="z-index: 1; left: 143px; top: 239px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:CheckBox ID="chkCustomerAccountStatus" runat="server" style="z-index: 1; left: 22px; top: 288px; position: absolute" Text="Account Status" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 22px; top: 377px; position: absolute; right: 1028px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 69px; top: 377px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
