<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="lec05Practica.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio sesión</title>
    <!--<link href="content/css/bootstrap.min.css" rel="stylesheet" />

    <script src="scripts/bootstrap.min.js"></script>
    <script src="scripts/jquery-3.3.1.min.js"></script>-->
    <link href="content/css/inicioSesion.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script> 
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section id="login">
                <div class="container">
    	            <div class="row">
    	                <div class="col-xs-12">
        	                <div class="form-wrap">
                                <h1>Inicio de Sesión</h1>
                                <hr />
                                <div class="form-group">
                                    <label for="tbUsuario" class="sr-only">Nombre de usuario: </label>
                                     <asp:TextBox ID="tbUsuario" runat="server" CssClass="form-control" placeholder="Nombre de Usuario"></asp:TextBox>
                                 </div>
                                 <div class="form-group">
                                    <label for="tbClave" class="sr-only">Contraseña: </label>
                                    <asp:TextBox ID="tbClave" TextMode="Password" runat="server" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
                                 </div>
                                 <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-custom btn-lg btn-block" OnClick="btnIngresar_Click" />
                                 <hr />
        	                </div>
    		            </div> <!-- /.col-xs-12 -->
    	            </div> <!-- /.row -->
                </div> <!-- /.container -->
            </section>
        </div>
    </form>
</body>
</html>
