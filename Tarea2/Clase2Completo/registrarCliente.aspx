<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrarCliente.aspx.cs" Inherits="Clase2Completo.registrarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar Cliente | Cafetería</title>
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
        <div class="row">
            <div class="col-lg-6">
            <h2>Registro</h2>
                <div class="form-group row">
                    <label for="txtNombre">Nombre</label>                    
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label1" runat="server" Text="Apellidos" for="txtApellido"></asp:Label>
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                    
                </div>
                <div class="form-group">
                    <asp:Label ID="Label8" runat="server" Text="Sexo" CssClass="form-check-label" for="rblSexo" ></asp:Label>
                    <asp:RadioButtonList ID="rblSexo" runat="server" class="form-check-input" RepeatDirection="Horizontal" RepeatLayout="Table" TextAlign="Left">
                    </asp:RadioButtonList>                
                    </div>
                <br />
                <div class="form-group row">
                    <asp:Label ID="Label2" runat="server" Text="Teléfono"  ></asp:Label>
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label3" runat="server" Text="Email" ></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label4" runat="server" Text="Provincia" ></asp:Label>
                    <asp:DropDownList ID="ddlProvincia" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label5" runat="server" Text="Password" ></asp:Label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label6" runat="server" Text="Confirmar Password" ></asp:Label>
                    <asp:TextBox ID="txtRepassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                    
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label7" runat="server" Text="Edad" ></asp:Label>
                    <asp:TextBox ID="txtEdad" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrarse" class="btn btn-primary"  />
                </div>
                <div>
                    <%Response.Write("Página abierta a las: " + DateTime.Now.ToLongTimeString()); %>
                </div>
                <div class="form-group row">
                    <label id="labelSelect"></label>
                    <asp:Label ID="labelSelect1" runat="server" Text=""></asp:Label>
                    <label id="labelSelect2" runat="server"></label>
                </div>
            </div>
        </div>
        <footer>
            <div id="info" runat="server"></div>
        </footer>
    </form>
</body>
</html>
