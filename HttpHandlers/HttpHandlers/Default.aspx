<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HttpHandlers.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 145px">
    <form id="form1" runat="server" >
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="GET" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="POST" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="PUT" OnClick="Button3_Click" />
        </div>
        <p>
            <asp:Button ID="Button4" runat="server" Text="StHandler" OnClick="Button4_Click"/>
            <asp:Button ID="Button5" runat="server" Text="SUM" OnClick="Button5_Click" />
        </p>
    </form>
</body>
</html>
