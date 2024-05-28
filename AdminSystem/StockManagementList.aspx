<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 225px; top: 477px; position: absolute; width: 120px" Text="Clear Filter" />
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 315px; width: 410px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 15px; top: 375px; position: absolute; width: 90px;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 124px; top: 375px; position: absolute; width: 90px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 534px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 236px; top: 375px; position: absolute; width: 90px" Text="Delete" />
        <asp:Label ID="lblFilterData" runat="server" style="z-index: 1; left: 18px; top: 441px; position: absolute; width: 155px; height: 17px; right: 964px" Text="Enter Item Description"></asp:Label>
        <asp:TextBox ID="txtFilterData" runat="server" style="z-index: 1; left: 202px; top: 436px; position: absolute; width: 205px"></asp:TextBox>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 28px; top: 477px; position: absolute; width: 120px" Text="Apply Filter" />
        </p>
    </form>
</body>
</html>
