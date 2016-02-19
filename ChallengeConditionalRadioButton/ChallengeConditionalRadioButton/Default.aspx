<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        Your note taking preferences
        <br />
        <br />
        <asp:RadioButton ID="pencilRadioButton" runat="server" GroupName="notes" Text="Pencil" />
        <br />
        <asp:RadioButton ID="penRadioButton" runat="server" GroupName="notes" Text="Pen" />
        <br />
        <asp:RadioButton ID="phoneRadioButton" runat="server" GroupName="notes" Text="Phone" />
        <br />
        <asp:RadioButton ID="tabletRadioButton" runat="server" GroupName="notes" Text="Tablet" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Image ID="Image" runat="server" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
