<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblGameTitle" runat="server" style="z-index: 1; left: 20px; top: 45px; position: absolute; width: 71px" Text="GameTitle"></asp:Label>
        <asp:TextBox ID="txtGameTitle" runat="server" style="z-index: 1; left: 125px; top: 45px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 20px; top: 88px; position: absolute; width: 55px" Text="Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 125px; top: 88px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPlatform" runat="server" style="z-index: 1; left: 20px; top: 128px; position: absolute" Text="Platform"></asp:Label>
        <asp:TextBox ID="txtPlatform" runat="server" style="z-index: 1; left: 125px; top: 128px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 20px; top: 166px; position: absolute" Text="ReleaseDate"></asp:Label>
        <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 125px; top: 166px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 40px; top: 240px; position: absolute; right: 886px;" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 160px; top: 240px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
