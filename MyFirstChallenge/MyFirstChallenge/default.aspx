<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="MyFirstChallenge._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        What is your age?
        <asp:TextBox ID="ageTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        How much money do you have in your pocket?
        <asp:TextBox ID="moneyTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="fortuneButton" runat="server" OnClick="fortuneButton_Click" Text="Click Me to see your fortune" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
