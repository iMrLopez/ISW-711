<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datosPersonales.aspx.cs" Inherits="Tarea1.datosPersonales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Datos Personales - Marny Lopez</title>
    <link href="css/estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
         <div>
        <header>
            <img src="img/a-grated.jpg" height="100" />
            <h1 id="titulo" runat="server"></h1>
        </header>
        <nav>
            <ul>
                <li><a href="datosPersonales.aspx">Datos Personales </a></li>
                <li><a href="pruebaCorta.aspx">Prueba Corta</a></li>
            </ul>
        </nav>
    </div>
    <div>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Primer Apellido: "></asp:Label><asp:TextBox ID="txtApellido1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Segundo Apellido: "></asp:Label><asp:TextBox ID="txtApellido2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Nombre Completo:  "> </asp:Label><asp:Label ID="lbCompleto" runat="server" Text="&quot; &quot;"></asp:Label>
    
    </div>
    </form>
</body>
</html>
