﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="UnderstandingWebApplicationsMTA.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebForm2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" />
            <br />
            <asp:Button ID="Button1" Text="Clear Session" runat="server" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
