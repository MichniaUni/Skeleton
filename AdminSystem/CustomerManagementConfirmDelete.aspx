<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #CCFFFF">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
            <asp:Button ID="btnYesDelete" runat="server" OnClick="btnYesDelete_Click" style="z-index: 1; left: 10px; top: 56px; position: absolute; color: #00FF00" Text="Yes" />
            <asp:Button ID="btnNoDelete" runat="server" OnClick="btnNoDelete_Click" style="z-index: 1; left: 82px; top: 56px; position: absolute; color: #CC0000" Text="No" width="42px" />
        </p>
    </form>
</body>
</html>
