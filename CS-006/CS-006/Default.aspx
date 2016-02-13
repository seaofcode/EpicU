<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_006.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            color: #FF6666;
        }
        .auto-style3 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Head Line 1</h1>
        <br />
        <br />
        <h2>Head Line 2</h2>
        <br />
        <br />
        <h3>Head Line 3</h3>
        <br />
        <br />
        <h4>Head Line 4<br />
        </h4>
        <br />
        <h5>HeadLine 5</h5>
        <br />
        <br />
        <h6>HeadLine 6</h6>
        <p class="auto-style1">
            This is somem text that I want to <span class="auto-style2">apply</span> a style to.</p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            <a href="http://www.learnvisualstudio.com">Add a hyper link</a></p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://microsoft.com">This is another hyperlink</asp:HyperLink>
        </p>
        <p class="auto-style1">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/turtle.jpg" />
        </p>
        <p class="auto-style1">
            &nbsp;</p>
        <table class="auto-style3">
            <tr>
                <td>Player</td>
                <td>Year</td>
            </tr>
            <tr>
                <td>Sammy Sosa</td>
                <td>2005<br />
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
        <ol>
            <li>First Item</li>
            <li>Second Item</li>
            <li>Third Item</li>
        </ol>
        <p>
            &nbsp;</p>
        <ul>
            <li>This is an idea</li>
            <li>another idea</li>
            <li>another</li>
        </ul>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
