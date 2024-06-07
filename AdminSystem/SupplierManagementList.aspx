<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">    <div>
        </div>
        <asp:ListBox ID="lstSupplierList" runat="server" Height="400px" Width="270px"></asp:ListBox><asp:Button runat="server" Text="Return To Main Menu" ID="btnReturn" OnClick="btnReturn_Click"></asp:Button>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" /><asp:Button runat="server" Text="Delete" ID="btndelete" OnClick="btndelete_Click"></asp:Button>
        </p>
        <asp:Label runat="server" Text="Enter A supplier Name:"></asp:Label>
        <p>
            <asp:TextBox runat="server" ID="txtFilter" OnTextChanged="txtFilter_TextChanged"></asp:TextBox>&nbsp;</p>
        <asp:Button runat="server" Text="Apply Filter" ID="btnApplyFilter" OnClick="btnApplyFilter_Click">

        </asp:Button><asp:Button runat="server" Text="Clear Filter" ID="btnClearFilter" OnClick="btnClearFilter_Click"></asp:Button>
        
        
        <p></p>
        
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
