<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 99px; position: absolute; height: 282px; width: 394px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 411px; position: absolute" Text="Add" />
        </div>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 76px; top: 412px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 629px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 143px; top: 412px; position: absolute" Text="Delete" />
        <asp:Label ID="lblEnterFirstName" runat="server" style="z-index: 1; left: 10px; top: 478px; position: absolute; right: 1578px; height: 63px" Text="Enter a first name"></asp:Label>
        <asp:TextBox ID="txtEnterFirstName" runat="server" OnTextChanged="txtEnterFirstName_TextChanged" style="z-index: 1; left: 290px; top: 479px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 10px; top: 561px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 170px; top: 561px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="btnBacktoMain" runat="server" OnClick="btnBacktoMain_Click" style="z-index: 1; left: 461px; top: 69px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>
