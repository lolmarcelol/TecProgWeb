<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisciplinaView.aspx.cs" Inherits="TecProgWeb.DisciplinaView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Curso"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropCurso" runat="server" OnSelectedIndexChanged="DropCurso_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Periodo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropPeriodo" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nome"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtNome" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Aulas Praticas"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtAulasPraticas" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Aulas Teoricas"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TxtAulasTeoricas" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Créditos"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtCreditos" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Total HA"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtTotalHa" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="TotalHR"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtTotalHr" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Save" runat="server" OnClick="Save_Click" Text="Save" />
    
    </div>
    </form>
</body>
</html>
