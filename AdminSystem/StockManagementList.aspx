﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 315px; width: 410px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 15px; top: 376px; position: absolute; width: 90px;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 124px; top: 376px; position: absolute; width: 90px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 423px; position: absolute"></asp:Label>
    </form>
</body>
</html>
