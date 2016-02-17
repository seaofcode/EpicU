<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengeSimpleCalculator._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Simple Calculator<br />
        <br />
        First Value
        <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Second Value
        <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="+" />
&nbsp;&nbsp;
        <asp:Button ID="subtractButton" runat="server" Text="-" OnClick="subtractButton_Click" />
&nbsp;&nbsp;
        <asp:Button ID="multiplyButton" runat="server" Text="*" OnClick="multiplyButton_Click" />
&nbsp;&nbsp;
        <asp:Button ID="divideButton" runat="server" Text="/" OnClick="divideButton_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
