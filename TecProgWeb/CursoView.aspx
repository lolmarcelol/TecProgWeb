<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CursoView.aspx.cs" Inherits="TecProgWeb.CursoView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
&nbsp;do curso&nbsp;
        <asp:TextBox ID="TxtNome" runat="server" Width="547px"></asp:TextBox>
        &nbsp;<br />
        <br />
        <asp:Button ID="BtnSave" runat="server" OnClick="BtnSave_Click" Text="Save" />
    
    </div>
    </form>
</body>
</html>
