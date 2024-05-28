<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body> <form id="form1" runat="server">
        &nbsp;<p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 376px; top: 50px; position: absolute" Text="Find" />
        </p>
        <div>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 9px; top: 17px; position: absolute; bottom: 587px" Text="Customer ID" width="124px"></asp:Label>
        </div>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 127px; top: 15px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 10px; top: 97px; position: absolute" Text="First Name" width="124px"></asp:Label>
        <p>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 127px; top: 94px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 10px; top: 198px; position: absolute" Text="Last Name" width="124px"></asp:Label>
        </p>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 127px; top: 195px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblAge" runat="server" style="z-index: 1; left: 10px; top: 299px; position: absolute" Text="Age" width="124px"></asp:Label>
        </p>
        <asp:TextBox ID="txtAge" runat="server" style="z-index: 1; left: 127px; top: 299px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 10px; top: 400px; position: absolute; width: 117px; height: 21px" Text="Phone Number"></asp:Label>
            <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 127px; top: 396px; position: absolute" width="168"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 8px; top: 505px; position: absolute" Text="Date Joined" width="124px"></asp:Label>
            <asp:TextBox ID="txtDateJoined" runat="server" style="z-index: 1; left: 127px; top: 502px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkisActive" runat="server" style="z-index: 1; left: 127px; top: 550px; position: absolute" Text="is Active" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 30px; top: 607px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 13px; top: 640px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 76px; top: 639px; position: absolute" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
