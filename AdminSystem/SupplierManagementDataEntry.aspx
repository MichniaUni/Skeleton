<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Your Data<br />
            <br />
            SupplierID&nbsp;
            <asp:TextBox ID="txtSupplierID" runat="server" Height="21px" Width="148px"></asp:TextBox>
            <br />
            <br />
            Supplier Name&nbsp;&nbsp;
            <asp:TextBox ID="txtSupplierName" runat="server" Height="22px" Width="144px" OnTextChanged="txtSupplierName_TextChanged"></asp:TextBox>
            <br />
            <br />
            Production Date&nbsp;&nbsp; <asp:TextBox ID="txtProductionDate" runat="server" Height="23px" Width="128px"></asp:TextBox>
            <br />
            <br />
            Expiry Date&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtExpiryDate" runat="server" Height="29px" Width="145px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkShipped" runat="server" style="z-index: 1; left: 155px; top: 416px; position: absolute; margin-bottom: 127px" Text="Shipped" />
            <br />
            <br />
            Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQuantity" runat="server" Height="29px" style="margin-bottom: 6px" Width="135px"></asp:TextBox>
            <br />
            <br />
            Price&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPrice" runat="server" Height="27px" Width="145px"></asp:TextBox>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 460px; position: absolute" Text="[lblError]"></asp:Label>
            <br />
            &nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnadd" runat="server" Height="35px" OnClick="btnadd_Click" Text="Add" Width="65px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Height="34px" Text="Cancel" OnClick="btnCancel_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
