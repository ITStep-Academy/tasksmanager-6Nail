<%@ Page Language="C#" EnableViewState="false" ViewStateMode="Disabled" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="TaskManager.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="count" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="button" runat="server" Text="Click Me!" OnClick="button_Click" />
        </div>
    </form>
</body>
</html>
