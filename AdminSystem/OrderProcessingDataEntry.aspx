﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 252px;
            width: 424px;
        }
    </style>
</head>
<body style="height: 261px; width: 497px">
   
    <form id="form1" runat="server">
        <div style="height: 261px; width: 418px">
            <asp:Label ID="lblPaymentMethod" runat="server" style="z-index: 1; left: 13px; top: 167px; position: absolute; height: 19px; width: 134px; right: 825px" Text="Payment Method"></asp:Label>
            <asp:CheckBox ID="chkIsCancelled" runat="server" style="z-index: 1; left: 179px; top: 217px; position: absolute; height: 32px; width: 124px" Text="Is cancelled" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 280px; position: absolute; height: 29px; width: 137px"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 125px; top: 337px; position: absolute; height: 33px; width: 91px; right: 1159px" Text="OK" />
        </div>
        <asp:Label ID="lblOrderId" runat="server" height="19px" style="z-index: 1; left: 10px; top: 37px; position: absolute; bottom: 766px; right: 828px" Text="Order ID" width="134px"></asp:Label>
        <p>
            <asp:TextBox ID="txtOrderId" runat="server" height="19px" style="z-index: 1; left: 180px; top: 32px; position: absolute; width: 197px"></asp:TextBox>
        </p>
        <asp:Button ID="btnFind" runat="server" height="33px" OnClick="btnFind_Click" Text="Find" width="91px" />
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 11px; top: 76px; position: absolute; height: 19px; width: 134px" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtPaymentMethod" runat="server" style="z-index: 1; left: 177px; top: 163px; position: absolute; height: 19px; width: 197px"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" height="19px" style="z-index: 1; left: 179px; top: 72px; position: absolute; width: 197px"></asp:TextBox>
        <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 11px; top: 123px; position: absolute; height: 19px; width: 134px" Text="Order Status"></asp:Label>
        <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; left: 179px; top: 115px; position: absolute; height: 19px; width: 197px"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" height="33px" style="z-index: 1; left: 244px; top: 336px; position: absolute" Text="Cancel" width="91px" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
