<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin: auto;
            width: 120px;
            max-height: 190px;
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .auto-style3 {
            font-size: xx-large;
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="spy_logo" class="auto-style1" src="epic-spies-logo.jpg" /><br class="auto-style2" />
        <br class="auto-style2" />
        <span class="auto-style3">Spy New Assignment Form</span><br />
        </div>
        <p>
            Spy Code Name :
            <asp:TextBox ID="spyNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name :
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment</p>
        <p>
            <asp:Calendar ID="previousCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment</p>
        <p>
            <asp:Calendar ID="startCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            End Date of New Assignment</p>
        <p>
            <asp:Calendar ID="endCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
