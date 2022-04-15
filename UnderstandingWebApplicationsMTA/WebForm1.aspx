<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UnderstandingWebApplicationsMTA.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebForm1</title>
</head>
<body>
    <br />
    <% = "Date: " + DateTime.Now.ToShortDateString() %>
    <br />
    <br />
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Label ID="Label1" runat="server"
                    Text="Please enter your name: " />
                <br />
                <asp:TextBox ID="TextBox1" runat="server" />
                <br />
                <br />
                <asp:Button ID="Button1" Text="Submit" runat="server" OnClick="Button1_Click" />
                <asp:Button ID="Examples" Text="View HTML, CSS, and JS Examples" runat="server" OnClick="ShowExamples_Click" />
            </h1>
        </div>
    </form>
</body>
</html>
