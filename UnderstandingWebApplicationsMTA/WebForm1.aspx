<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UnderstandingWebApplicationsMTA.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebForm1</title>
</head>
<body>
    <% = DateTime.Now.ToShortDateString() %>

    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server"
                Text="Please enter your name: " /> 
            <br />
            <asp:TextBox ID="TextBox1" runat="server" />
            <br />
            <br />
            <asp:Button ID="Button1" Text="Submit" runat="server" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
