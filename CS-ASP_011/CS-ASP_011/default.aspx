<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_ASP_011._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Is
        <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp;equal to
        <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp;?<br />
        <br />
        <br />
        <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are you cool" />
        <br />
        <br />
        If you could only have one food for the rest of your life, what would it be?<br />
        <asp:RadioButton ID="pizzaRadioButton" runat="server" GroupName="Food" Text="Pizza" />
        <br />
        <asp:RadioButton ID="saladRadioButton" runat="server" GroupName="Food" Text="Salad" />
        <br />
        <asp:RadioButton ID="PBJRadioButton" runat="server" GroupName="Food" Text="PB &amp; J" />
        <br />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Ok" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
