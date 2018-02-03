<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pruebaCorta.aspx.cs" Inherits="Tarea1.pruebaCorta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Prueba Corta - Marny Lopez</title>
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
        <asp:Label ID="lbTitulo" runat="server"></asp:Label>
    

        <br />
         <h3>Respuesta Única</h3>
        <h3>Pregunta 1:</h3>

        En HTML, la etiqueta &lt;caption&gt se emplea para:<br />
        <br />
        <asp:RadioButtonList ID="rdbPreg1" runat="server">
            <asp:ListItem>a) Definir el título de la página </asp:ListItem>
            <asp:ListItem>b) Definir el título de una imagen</asp:ListItem>
            <asp:ListItem>c) Definir el título de una tabla</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lbPreg1" runat="server" Text=" " style="color: red;"></asp:Label>
        <br />
        <asp:Label ID="lbPreg1_0" runat="server" Text=" " style="color: red;"></asp:Label>
        <br />
        <h3>Pregunta 2:</h3>
        En HTML, &lt;input name="boton" type="submit" value="cargar" id="enviar"> muestra un botón con el texto:<br />
        <br />
        <asp:RadioButtonList ID="rdbPreg2" runat="server">
            <asp:ListItem>a) botón</asp:ListItem>
            <asp:ListItem>b) cargar </asp:ListItem>
            <asp:ListItem>c) enviar</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lbPreg2" runat="server" Text=" " style="color: red;"></asp:Label>
        <br />
        <asp:Label ID="lbPreg2_0" runat="server" Text=" " style="color: red;"></asp:Label>
        <br />
        <h3>Pregunta 3:</h3>
        En HTML, para indicar que una celda de una tabla es un encabezado se emplea la etiqueta:
        <asp:RadioButtonList ID="rdbPreg3" runat="server" Width="119px">
            <asp:ListItem>a) tr</asp:ListItem>
            <asp:ListItem>b) th</asp:ListItem>
            <asp:ListItem>c) td</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lbPreg3" runat="server" Text=" " style="color: red;"></asp:Label>
        <br />
        <asp:Label ID="lbPreg3_0" runat="server" Text=" " style="color: red;"></asp:Label>
        <br />
        <h3>Pregunta 4:</h3>
        ¿Qué atributo de HTML se emplea normalmente en la etiqueta que define un formulario?
        <asp:RadioButtonList ID="rdbPreg4" runat="server">
            <asp:ListItem>a) alt=&quot;Actividades&quot; </asp:ListItem>
            <asp:ListItem>b) href =&quot;#actividades&quot; </asp:ListItem>
            <asp:ListItem Value="c) method=&quot;post&quot; ">c) method=&quot;post&quot; </asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lbPreg4" runat="server" Text=" " style="color: red;"></asp:Label>
        <br />
        <asp:Label ID="lbPreg4_0" runat="server" Text=" " style="color: red;"></asp:Label>
        <br />
        <br class="Apple-interchange-newline" />
        <p style="color: rgb(0, 51, 102); font-family: Verdana, Tahoma, Arial, Helvetica, sans-serif; background-color: rgb(189, 206, 214); font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;">&nbsp;</p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Revisar" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Respuestas correctas : " style="color: red;"></asp:Label>
&nbsp;
        <asp:Label ID="lbCorrectas" runat="server" Text="0" style="color: red;"></asp:Label>
&nbsp;
        <asp:Label ID="Label2" runat="server" Text=" de 4" style="color: red;"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
