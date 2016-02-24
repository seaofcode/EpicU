<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_022.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        From:<br />
        <br />
        <asp:RadioButton ID="chicagoRadioButton" runat="server" GroupName="From" Text="Chicago" />
        <br />
        <asp:RadioButton ID="newYorkRadioButton" runat="server" GroupName="From" Text="New York" />
        <br />
        <asp:RadioButton ID="londonRadioButton" runat="server" GroupName="From" Text="London" />
        <br />
        <br />
        To:<br />
        <br />
        <asp:RadioButton ID="chicago2RadioButton" runat="server" GroupName="To" Text="Chicago" />
        <br />
        <asp:RadioButton ID="newYork2RadioButton" runat="server" GroupName="To"  Text="New York" />
        <br />
        <asp:RadioButton ID="london2RadioButton" runat="server" GroupName="To" Text="London" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
        <br />
        <br />
        Ticket Price : <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
