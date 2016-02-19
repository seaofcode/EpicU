<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFirstPapaBobsPizza.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 200px;
            height: 200px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style3 {
            font-size: xx-large;
        }
        .auto-style4 {
            font-size: x-large;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style5 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img class="auto-style1" src="PapaBob.png" /><span class="auto-style2"><span class="auto-style3">Papa Bob&#39;s Pizza and Software</span><br />
        <br />
        </span>
    
    </div>
        <asp:RadioButton ID="babyBobSizeRadioButton" runat="server" GroupName="Size" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="mamaBobSizeRadioButton" runat="server" GroupName="Size" Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="papaBobSizeRadioButton" runat="server" GroupName="Size" Text="Papa Bob Size (16&quot;) - $16" />
        <br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Crust" Text="Thin" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Crust" Text="Deep Dish (+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="onionCheckBox" runat="server" Text="Onions (+$0.75)" />
        <br />
        <asp:CheckBox ID="greenPepperCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="redPepperCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
        <br />
        <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies (+$2.00)" />
        <br />
        <p class="auto-style4">
            <strong>Papa Bob&#39;s <span class="auto-style5">Special Deal</span></strong></p>
        <p>
            Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.</p>
        <p>
            <asp:Button ID="totalButton" runat="server" Text="Purchase" />
        </p>
        <p>
            Total:
            <asp:Label ID="totalLabel" runat="server" Text="$0.00"></asp:Label>
        </p>
    </form>
    <p>
        Sorry, at this time you can only order one pizza online and pick up only....we need a better website!</p>
</body>
</html>
