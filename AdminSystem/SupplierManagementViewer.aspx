<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierManagementViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the Supplier Management Viewer Page
    <form id="form1" runat="server">
        <br />
        <br />
        <asp:ListBox ID="lstData" runat="server" Height="149px" Width="300px"></asp:ListBox>
        <br />
        <br />
        <p>
            Enter SupplierID
            <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="155px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" Height="29px" Text="Search" Width="80px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnAdd" runat="server" Height="38px" Text="Add" Width="88px" OnClick="btnAdd_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" Height="39px" style="margin-top: 0px; margin-left: 0px;" Text="Edit" Width="78px" OnClick="btnEdit_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Height="39px" OnClick="btnDelete_Click" Text="Delete" Width="110px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
