<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockManagementConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 125px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Are you Sure you want to delete this record?"></asp:Label>
        <p>
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 166px; top: 75px; position: absolute; width: 60px" Text="No" />
        </p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 38px; top: 75px; position: absolute; width: 60px; right: 587px" Text="Yes" />
    </form>
</body>
</html>
