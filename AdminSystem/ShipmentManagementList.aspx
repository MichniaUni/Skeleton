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
            height: 413px;
        }
        .auto-style2 {
            position: absolute;
            top: 463px;
            left: 32px;
            z-index: 1;
            width: 56px;
        }
        .auto-style3 {
            position: absolute;
            top: 463px;
            left: 149px;
            z-index: 1;
            width: 56px;
        }
        .auto-style4 {
            position: absolute;
            top: 643px;
            left: 18px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 463px;
            left: 273px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 166px;
            left: 402px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 213px;
            z-index: 1;
            width: 152px;
            left: 383px;
        }
        .auto-style8 {
            position: absolute;
            top: 271px;
            z-index: 1;
            right: 477px;
            height: 24px;
            bottom: 381px;
        }
        .auto-style9 {
            position: absolute;
            top: 117px;
            left: 406px;
            z-index: 1;
            right: 473px;
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
            <asp:Label ID="lblepostcode" runat="server" CssClass="auto-style6" Text="Enter a Post Code"></asp:Label>
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
            <asp:Button ID="btnEdit0" runat="server" CssClass="auto-style3" OnClick="btnEdit_Click" Text="Edit" />
            <br />
            <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" CssClass="auto-style5" OnClick="btnDelete_Click" Text="Delete" />
            <br />
            <br />
            <asp:TextBox ID="txtepostcode" runat="server" CssClass="auto-style7"></asp:TextBox>
            <br />
            <asp:Label ID="lblError" runat="server" CssClass="auto-style4"></asp:Label>
            <br />
            <asp:Button ID="btnapply" runat="server" CssClass="auto-style9" OnClick="btnapply_Click" Text="Apply Filter" />
            <br />
            <asp:Button ID="btnclear" runat="server" CssClass="auto-style8" OnClick="btnclear_Click" Text="Clear Filter" />
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:ListBox ID="lstshipmentlist" runat="server" CssClass="auto-style1"></asp:ListBox>
    </form>
</body>
</html>
