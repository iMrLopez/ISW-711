<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="lec05Practica.RegistrarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="width: 60%;">
    <!-- Mensajes de verificacion y error -->
        <div class="alert alert-sucess" style="background-color: #caf7d0;" visible="false" id="mensaje" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <strong id="textoMensaje" runat="server"></strong>
        </div>
        <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <strong id="textoMensajeError" runat="server"></strong>
        </div>
    </div>
    <!-- Formulario -->
    <div class="container" style="width: 60%;">
        <h3>Nuevo usuario</h3>
        <hr />
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Número de identificación: "></asp:Label>
            <asp:TextBox ID="tbIdentificacion" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbIdentificacion" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Se requiere el número de identificación</asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox ID="tbNombre" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbNombre" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Se requiere el nombre</asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Apellidos: "></asp:Label>
            <asp:TextBox ID="tbApellidos" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbApellidos" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Se requiere los apellidos</asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Nombre de usuario: "></asp:Label>
            <asp:TextBox ID="tbNombreUsuario" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbNombreUsuario" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Se requiere el nombre de usuario</asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Contraseña: "></asp:Label>
            <asp:TextBox ID="tbClave" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbClave" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Se requiere la contraseña</asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Tipo usuario: "></asp:Label>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <div class="row">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="col-md-6">
                        <asp:DropDownList ID="ddlTipoUsuario" CssClass="form-control" Width="400" runat="server" OnSelectedIndexChanged="ddlTipoUsuario_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                    </div>
                    <div class="col-md-6">
                        <asp:Label ID="lbDescripcionTipoUsuario" ForeColor="#3399ff" Font-Size="Large" runat="server" Text=""></asp:Label>
                    </div>                  
                </ContentTemplate>
            </asp:UpdatePanel>
            </div>
            <asp:HiddenField ID="hfCodUsuario" runat="server" /> 
        </div>
        <hr />
        <asp:Button ID="btRegistrar" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btRegistrar_Click" />
        <asp:Button ID="btCancelar" runat="server" Text="Cancelar" CssClass="btn btn-default" />
        <br />
    </div>
</asp:Content>
