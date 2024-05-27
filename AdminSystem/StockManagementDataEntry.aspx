<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 510px">
    <form id="form1" runat="server">
        <asp:Label ID="lblItemId" runat="server" height="25px" style="z-index: 1; left: 11px; top: 39px; position: absolute" Text="ItemId" width="150px"></asp:Label>
        <asp:Label ID="lblQuantityInStock" runat="server" Height="25px" style="z-index: 1; left: 11px; top: 160px; position: absolute; height: 23px; width: 150px" Text="QuantityInStock"></asp:Label>
        <asp:Label ID="lblItemPrice" runat="server" height="25px" style="z-index: 1; left: 11px; top: 200px; position: absolute" Text="ItemPrice" width="150px"></asp:Label>
        <p>
            <asp:TextBox ID="txtItemId" runat="server" height="25px" style="z-index: 1; left: 202px; top: 33px; position: absolute; width: 319px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 556px; top: 35px; position: absolute; width: 117px" Text="Find" />
        </p>
        <p>
            <asp:TextBox ID="txtItemDescription" runat="server" height="25px" style="z-index: 1; left: 202px; top: 76px; position: absolute; width: 319px"></asp:TextBox>
            <asp:Label ID="lblItemDescription" runat="server" height="25px" style="z-index: 1; left: 11px; top: 82px; position: absolute" Text="ItemDescription" width="150px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblRestockDate" runat="server" height="25px" style="z-index: 1; left: 11px; top: 123px; position: absolute" Text="RestockDate" width="150px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtRestockDate" runat="server" style="z-index: 1; left: 202px; top: 117px; position: absolute; width: 319px; height: 25px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtQuantityInStock" runat="server" height="25px" style="z-index: 1; left: 202px; top: 152px; position: absolute; width: 319px"></asp:TextBox>
        <asp:TextBox ID="txtItemPrice" runat="server" height="25px" style="z-index: 1; left: 202px; top: 194px; position: absolute; width: 319px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkIsActive" runat="server" style="z-index: 1; left: 202px; top: 249px; position: absolute; width: 326px" Text="IsActive" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 123px; top: 373px; position: absolute; width: 80px" Text="Cancel" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 319px; position: absolute"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 11px; top: 373px; position: absolute; width: 80px" Text="OK" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
