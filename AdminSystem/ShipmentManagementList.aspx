<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShipmentManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 19px;
            left: 16px;
            z-index: 1;
            width: 348px;
            height: 453px;
        }
        .auto-style2 {
            position: absolute;
            top: 506px;
            left: 30px;
            z-index: 1;
            width: 56px;
        }
        .auto-style3 {
            position: absolute;
            top: 507px;
            left: 109px;
            z-index: 1;
            width: 56px;
        }
        .auto-style4 {
            position: absolute;
            top: 573px;
            left: 20px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnEdit" runat="server" CssClass="auto-style3" OnClick="btnEdit_Click" Text="Edit" />
            <br />
            <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" OnClick="btnAdd_Click" Text="Add" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" CssClass="auto-style4"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:ListBox ID="lstshipmentlist" runat="server" CssClass="auto-style1"></asp:ListBox>
    </form>
</body>
</html>
