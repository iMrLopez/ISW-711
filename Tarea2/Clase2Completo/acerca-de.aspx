<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="acerca-de.aspx.cs" Inherits="Clase2Completo.acerca_de" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Acerca del Café | Cafetería</title>
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
                    <asp:HyperLink CssClass="nav-link" ID="HyperLink1" runat="server" NavigateUrl="~/acerca-de.aspx">Acerca del Café</asp:HyperLink>
                </li>
            </ul>

        </div>
    </nav>
    <form id="form2" runat="server" class="container">
        <h2>Acerca del café</h2>
        <div class="row">
            <div class="col-lg-4">
                <div class="card border-dark mb-3" style="max-width: 20rem;">
                    <div class="card-header">Recetas</div>
                    <img src="img/espresso-1181158_960_720.jpg" style="height: 200px; width: 100%; display: block;" />
                    <div class="card-body">
                        <p class="card-text">Descubra nuevas formas clásicas y creativas de disfrutar el café.</p>
                    </div>
                    <div class="card-body">
                        <a href="#">Más información</a>
                    </div>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="card border-info mb-3" style="max-width: 20rem;">
                    <div class="card-header">Consejos de Barista</div>
                    <img src="img/coffee-2431159_960_720.jpg" style="height: 200px; width: 100%; display: block;" />
                    <div class="card-body">
                        <p class="card-text">Consejos para un café aún mejor.</p>
                    </div>
                    <div class="card-body">
                        <a href="#">Más información</a>
                    </div>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="card border-secondary mb-3" style="max-width: 20rem;">
                    <div class="card-header">Historia Café</div>
                    <img src="img/coffee-2225564_960_720.jpg" style="height: 200px; width: 100%; display: block;" />
                    <div class="card-body">
                        <p class="card-text">Todo lo que siempre quisiste saber sobre el café</p>
                    </div>
                    <div class="card-body">
                        <div class="card-body"><a href="#">Más información</a></div>

                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
