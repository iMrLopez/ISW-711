﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Clase2Completo._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio | Cafetería</title>
     <script src="~/Scripts/jquery-3.0.0.js"></script>
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="~/Scripts/bootstrap.js"></script>
</head>
<body>
     <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
        <a class="navbar-brand" href="default.aspx">Cafetería</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarColor01">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item">
                    <asp:HyperLink CssClass="nav-link" ID="HyperLink3" runat="server" NavigateUrl="~/default.aspx">Inicio</asp:HyperLink>
                </li>
                <li class="nav-item">
                    <asp:HyperLink CssClass="nav-link" ID="HyperLink4" runat="server" NavigateUrl="~/registrarCliente.aspx">Registar Cliente</asp:HyperLink>
                </li>
                <li class="nav-item">
                    <asp:HyperLink CssClass="nav-link" ID="HyperLink1" runat="server"  NavigateUrl="~/acerca-de.aspx">Acerca del Café</asp:HyperLink>
                </li>
            </ul>
            
        </div>
    </nav>
    <form id="form2" runat="server" class="container">
        <div class="row">
            <img src="img/coffee-flower-280734_1280.jpg" class="img-fluid" alt="Flor de cafe" />
        </div>
    </form>
</body>
</html>
