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
        <asp:Label ID="lblGameTitle" runat="server" style="z-index: 1; left: 26px; top: 141px; position: absolute; width: 71px; height: 20px;" Text="GameTitle"></asp:Label>
        <asp:TextBox ID="txtGameTitle" runat="server" style="z-index: 1; left: 182px; top: 138px; position: absolute; margin-bottom: 0px;"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 28px; top: 182px; position: absolute; width: 55px" Text="Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 181px; top: 184px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPlatform" runat="server" style="z-index: 1; left: 27px; top: 222px; position: absolute" Text="Platform"></asp:Label>
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 33px; top: 272px; position: absolute" Text="ReleaseDate"></asp:Label>
        <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 180px; top: 270px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 65px; top: 387px; position: absolute; right: 1164px; height: 26px;" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 172px; top: 386px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 406px; top: 50px; position: absolute" Text="Find" />
        <asp:Label ID="lblProductId" runat="server" style="z-index: 1; left: 23px; top: 53px; position: absolute; height: 22px; width: 90px" Text="ProductId"></asp:Label>
        <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; left: 181px; top: 52px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 26px; top: 94px; position: absolute" Text="Is The Game In Stock?" />
        <asp:Label ID="lblStockQuantity" runat="server" style="z-index: 1; left: 28px; top: 321px; position: absolute; height: 19px; width: 99px" Text="Stock Quantity"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server" style="z-index: 1; left: 180px; top: 315px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="drpPlatform" runat="server" style="z-index: 1; left: 184px; top: 226px; position: absolute; height: 30px; width: 110px">
            <asp:ListItem>Playstation 4</asp:ListItem>
            <asp:ListItem>Playstation 3</asp:ListItem>
            <asp:ListItem>Playstation 2</asp:ListItem>
            <asp:ListItem>Playstation</asp:ListItem>
            <asp:ListItem>Xbox One</asp:ListItem>
            <asp:ListItem>Xbox 360</asp:ListItem>
            <asp:ListItem>Xbox</asp:ListItem>
            <asp:ListItem>Switch</asp:ListItem>
            <asp:ListItem>3DS</asp:ListItem>
            <asp:ListItem>DS</asp:ListItem>
            <asp:ListItem>Gameboy Advance</asp:ListItem>
            <asp:ListItem>Gameboy Color</asp:ListItem>
            <asp:ListItem>Gameboy</asp:ListItem>
            <asp:ListItem>PS Vita</asp:ListItem>
            <asp:ListItem>PSP</asp:ListItem>
            <asp:ListItem>Wii</asp:ListItem>
            <asp:ListItem>Gamecube</asp:ListItem>
            <asp:ListItem>N64</asp:ListItem>
            <asp:ListItem>SNES</asp:ListItem>
            <asp:ListItem>NES</asp:ListItem>
            <asp:ListItem>Sega Dreamcast</asp:ListItem>
            <asp:ListItem>Sega Saturn</asp:ListItem>
            <asp:ListItem>Sega Megadrive</asp:ListItem>
            <asp:ListItem>Sega Master System</asp:ListItem>
            <asp:ListItem>Sega Gamegear</asp:ListItem>
            <asp:ListItem>Atari 2600</asp:ListItem>
            <asp:ListItem>ZX Spectrum</asp:ListItem>
            <asp:ListItem>Commodore64</asp:ListItem>
            <asp:ListItem>PC</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 331px; top: 387px; position: absolute"></asp:Label>
    </form>
</body>
</html>
