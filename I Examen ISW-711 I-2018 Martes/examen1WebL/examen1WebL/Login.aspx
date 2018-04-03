<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="examen1WebL.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio Sesion</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

                <asp:Label ID="Label1" runat="server" Text="Label">Usuario</asp:Label>
    <asp:TextBox ID="Usuario" runat="server"></asp:TextBox>

    <p></p>
    <asp:Label ID="Label2" runat="server" Text="Label">Contraseña</asp:Label>
    <asp:TextBox ID="Contrasenna" runat="server"></asp:TextBox>

    <p></p>
    <asp:Button ID="Button2" runat="server" Text="Iniciar Sesion" OnClick="Button2_Click" />

        </div>
    </form>
</body>
</html>
