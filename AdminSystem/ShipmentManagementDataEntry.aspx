<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShipmentManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <asp:Label ID="lblpostcode" runat="server" style="z-index: 1; left: 12px; top: 219px; position: absolute" Text="Postcode" width="83px"></asp:Label>
            <asp:Label ID="lbldeliverydate" runat="server" style="z-index: 1; left: 10px; top: 254px; position: absolute" Text="Delivery Date"></asp:Label>
            <asp:Label ID="lblshipmentid" runat="server" style="z-index: 1; left: 10px; top: 72px; position: absolute; bottom: 585px;" Text="Shipment ID" width="83px"></asp:Label>
            <asp:Label ID="lblstreet" runat="server" style="z-index: 1; left: 11px; top: 144px; position: absolute" Text="Street" width="83px"></asp:Label>
            <asp:Label ID="lblordernum" runat="server" style="z-index: 1; left: 11px; top: 109px; position: absolute; width: 101px;" Text="Order Number"></asp:Label>
            <asp:Label ID="lblcity" runat="server" style="z-index: 1; left: 12px; top: 180px; position: absolute" Text="City" width="83px"></asp:Label>
            <asp:Label ID="lblerror" runat="server" style="z-index: 1; left: 13px; top: 311px; position: absolute"></asp:Label>
            <br />
            <asp:TextBox ID="txtordernum" runat="server" style="z-index: 1; left: 175px; top: 109px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtdeliverydate" runat="server" style="z-index: 1; left: 173px; top: 252px; position: absolute"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtshipmentid" runat="server" style="z-index: 1; left: 175px; top: 68px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtstreet" runat="server" style="z-index: 1; left: 174px; top: 144px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtcity" runat="server" style="z-index: 1; left: 175px; top: 185px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtpostcode" runat="server" style="z-index: 1; left: 175px; top: 221px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btncancel" runat="server" style="z-index: 1; left: 286px; top: 341px; position: absolute" Text="Cancel" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnok" runat="server" style="z-index: 1; left: 89px; top: 344px; position: absolute; width: 59px" Text="OK" OnClick="btnok_Click" />
            <br />
            <br />
            <br />
            <asp:CheckBox ID="chkisdeliveryexpress" runat="server" style="z-index: 1; left: 107px; top: 289px; position: absolute" Text="Express Delivery" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
