<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Postal Calculator<p>
            Width:
            <asp:TextBox ID="widthTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Length:
            <asp:TextBox ID="lengthTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Height:
            <asp:TextBox ID="heightTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;<asp:RadioButton ID="groundRadioButton" runat="server" Text="Ground" />
        </p>
        <p>
            <asp:RadioButton ID="airRadioButton" runat="server" Text="Air" />
        </p>
        <p>
            <asp:RadioButton ID="nextDayRadioButton" runat="server" Text="Next Day" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
