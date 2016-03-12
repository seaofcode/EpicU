<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaCasinoChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" />
        <asp:Image ID="Image2" runat="server" Height="150px" Width="150px" />
        <asp:Image ID="Image3" runat="server" Height="150px" Width="150px" />
        <br />
    
    </div>
        <p>
            Your Bet:
            <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="pullButton" runat="server" OnClick="pullButton_Click" Text="Pull the Lever" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="moneyLabel" runat="server"></asp:Label>
        </p>
        <p>
            1 Cherry - x2 Your bet</p>
        <p>
            2 Cherry - x3 Your bet</p>
        <p>
            3 Cherry - x4 Your bet</p>
        <p>
            3 7s Jackpot - x100 Your bet</p>
        <p>
            HOWEVER.....if there is even one bar you win nothing</p>
    </form>
</body>
</html>
