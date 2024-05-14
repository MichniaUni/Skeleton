<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 241px; width: 379px">
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 14px; top: 33px; position: absolute" Text="OrderId" width="131px"></asp:Label>
        </p>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 159px; top: 31px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 15px; top: 77px; position: absolute" Text="OrderDate" width="131px"></asp:Label>
        <p>
            <asp:TextBox ID="txtOrderDate" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 159px; top: 71px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 14px; top: 123px; position: absolute" Text="Order Status" width="131px"></asp:Label>
        <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; left: 159px; top: 119px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPaymentMethod" runat="server" style="z-index: 1; left: 16px; top: 165px; position: absolute" Text="Payment Method"></asp:Label>
        <asp:TextBox ID="txtPaymentMethod" runat="server" style="z-index: 1; left: 159px; top: 164px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="chkIsCancelled" runat="server" style="z-index: 1; left: 162px; top: 206px; position: absolute" Text="Cancelled" />
        <p>
&nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 268px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 88px; top: 312px; position: absolute; right: 879px;" Text="OK" width="77px" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 182px; top: 312px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
