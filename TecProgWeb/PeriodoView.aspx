<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PeriodoView.aspx.cs" Inherits="TecProgWeb.PeriodoView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Curso"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropCurso" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="TxtPeriodo" runat="server" Text="Periodo"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Save" runat="server" OnClick="Save_Click" Text="Save" />
    
    </div>
    </form>
</body>
</html>
