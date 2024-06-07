<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" Height="351px" Width="579px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" style="height: 29px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="margin-left: 69px" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="margin-left: 87px" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lblEnterPaymentMethod" runat="server" Text="Enter a payment method"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" Height="16px" style="margin-left: 13px; margin-top: 5px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="margin-left: 56px" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="margin-left: 35px" Text="Clear Filter" />
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="margin-left: 38px" Text="Return to Main Menu" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
