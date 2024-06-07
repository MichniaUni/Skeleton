<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingLogin.aspx.cs" Inherits="OrderProcessingLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 482px;
            height: 272px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" Text="Order Processing Login Page"></asp:Label>
        <p>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 118px; top: 75px; position: absolute; width: 128px; height: 25px"></asp:TextBox>
        </p>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 20px; top: 80px; position: absolute" Text="UserName"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 21px; top: 128px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" height="25px" style="z-index: 1; left: 117px; top: 123px; position: absolute; width: 128px" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" height="26px" OnClick="btnLogin_Click" style="z-index: 1; left: 96px; top: 184px; position: absolute" Text="Login" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 192px; top: 185px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 499px; top: 121px; position: absolute"></asp:Label>
    </form>
</body>
</html>
