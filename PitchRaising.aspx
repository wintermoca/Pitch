<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PitchRaising.aspx.cs" Inherits="View.PitchRaising" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="text-align: center">
        <asp:Label ID="lblTitle" runat="server" Text="피치를 올려라!"></asp:Label>
        <br />
        <asp:Button ID="btnPitchDown" runat="server" OnClick="btnPitchDown_Click" Text="한 음 내리기" />
        <asp:Label ID="lblPitch" runat="server" Text="라"></asp:Label>
        <asp:Button ID="btnPitchUp" runat="server" Text="한 음 올리기" />
    </form>
</body>
</html>
