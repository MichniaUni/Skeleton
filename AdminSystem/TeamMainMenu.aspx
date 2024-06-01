<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 281px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMainManu" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 132px; top: 46px; position: absolute" Text="Heroes Drones Main Menu"></asp:Label>
        <asp:Button ID="btnCustomer" runat="server" Font-Bold="True" OnClick="btnCustomer_Click" style="z-index: 1; left: 28px; top: 127px; position: absolute; width: 150px; height: 45px" Text="Customer" />
        <asp:Button ID="btnOrder" runat="server" Font-Bold="True" height="45px" OnClick="btnOrder_Click" style="z-index: 1; left: 417px; top: 127px; position: absolute" Text="Order" width="150px" />
        <asp:Button ID="btnStaff" runat="server" Font-Bold="True" height="45px" OnClick="btnStaff_Click" style="z-index: 1; left: 128px; top: 197px; position: absolute" Text="Staff" width="150px" />
        <asp:Button ID="btnSupplier" runat="server" Font-Bold="True" height="45px" OnClick="btnSupplier_Click" style="z-index: 1; left: 322px; top: 197px; position: absolute" Text="Supplier" width="150px" />
        <p>
            <asp:Button ID="btnStock" runat="server" Font-Bold="True" height="45px" OnClick="btnStock_Click" style="z-index: 1; left: 225px; top: 127px; position: absolute" Text="Stock" width="150px" />
        </p>
    </form>
</body>
</html>
