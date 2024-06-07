<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 105px;
            width: 529px;
        }
    </style>
</head>
<body style="height: 95px; width: 523px; margin-left: 134px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblConfirmDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnYes" runat="server" height="29px" OnClick="btnYes_Click" style="margin-left: 118px" Text="Yes" width="42px" />
        <asp:Button ID="btnNO" runat="server" height="29px" OnClick="btnNO_Click" style="margin-left: 47px" Text="No" width="42px" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
