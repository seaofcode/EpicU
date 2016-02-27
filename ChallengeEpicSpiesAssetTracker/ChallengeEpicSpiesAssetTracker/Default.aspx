<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
            height: 150px;
        }
        .auto-style2 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="Spy_Logo" class="auto-style1" src="epic-spies-logo.jpg" /><br />
        <br />
        <span class="auto-style2"><strong>Asset Performance Tracker</strong></span><br />
        </div>
        <p>
            Asset Name :
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Elections Rigged :
            <asp:TextBox ID="electionTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfudge Performed :
            <asp:TextBox ID="subterfudgeTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="addAsset" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
