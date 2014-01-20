<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Versaler.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>
        Hur många versaler
    </h1>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox" runat="server"></asp:TextBox>
        <asp:Button ID="SubmitButton" runat="server" Text="Bestäm antalet versaler" onclick="Button_Click"/>
        <asp:Button ID="ClearButton" runat="server" Text="Rensa" onclick="Clear_Click"/>
        <asp:Label ID="ResponseText" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
