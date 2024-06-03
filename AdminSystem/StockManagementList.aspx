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
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 225px; top: 477px; position: absolute; width: 120px" Text="Clear Filter" BackColor="#0066FF" BorderColor="#0099FF" BorderStyle="Solid" ForeColor="White" />
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 315px; width: 410px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 15px; top: 375px; position: absolute; width: 90px;" Text="Add" BackColor="#0066FF" BorderColor="#0099FF" BorderStyle="Solid" ForeColor="White" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 124px; top: 375px; position: absolute; width: 90px" Text="Edit" BackColor="#0066FF" BorderColor="#0099FF" BorderStyle="Solid" ForeColor="White" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 534px; position: absolute" ForeColor="#CC0000"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 236px; top: 375px; position: absolute; width: 90px" Text="Delete" BackColor="#0066FF" BorderColor="#0099FF" BorderStyle="Solid" ForeColor="White" />
        <asp:Label ID="lblFilterData" runat="server" style="z-index: 1; left: 18px; top: 441px; position: absolute; width: 208px; height: 17px; right: 1056px" Text="Enter Item Description"></asp:Label>
        <asp:TextBox ID="txtFilterData" runat="server" style="z-index: 1; left: 257px; top: 436px; position: absolute; width: 214px"></asp:TextBox>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 28px; top: 477px; position: absolute; width: 120px" Text="Apply Filter" BackColor="#0066FF" BorderColor="#0099FF" BorderStyle="Solid" ForeColor="White" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 349px; top: 375px; position: absolute; width: 183px" Text="Return To Main Menu" BackColor="#0066FF" BorderColor="#0099FF" BorderStyle="Solid" ForeColor="White" />
        </p>
    </form>
</body>
</html>
