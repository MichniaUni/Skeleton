<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 364px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 35px; top: 37px; position: absolute; text-decoration: underline;" Text="Customer Login Page"></asp:Label>
        <p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 21px; top: 135px; position: absolute" Text="User Name:"></asp:Label>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 21px; top: 175px; position: absolute" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 160px; top: 132px; position: absolute; width: 200px"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 160px; top: 172px; position: absolute; width: 200px" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 46px; top: 269px; position: absolute; right: 1741px; color: #000000; background-color: #00FF00;" Text="Login" Width="100px" BackColor="#0066FF" BorderColor="#0066FF" BorderStyle="Solid" ForeColor="White" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 205px; top: 270px; position: absolute; width: 100px; background-color: #FF0000;" Text="Cancel" OnClick="btnCancel_Click" BackColor="#0066FF" BorderColor="#0066FF" BorderStyle="Solid" ForeColor="White" />
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="#CC0000" style="z-index: 1; left: 119px; top: 228px; position: absolute"></asp:Label>
            </p>
    </form>
</body>
</html>
