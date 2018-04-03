<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoUsuarios.aspx.cs" Inherits="lec05Practica.ListadoUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container">
        <h3>Lista de usuarios</h3>
        <hr />
        <asp:GridView ID="dgvUsuarios" runat="server" AutoGenerateColumns="False" CssClass="table thead-dark table-hover" DataKeyNames="idUsuario" DataSourceID="SqlDataSource1" AllowPaging="True" OnSelectedIndexChanged="dgvUsuarios_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="idUsuario" HeaderText="Código" InsertVisible="False" ReadOnly="True" SortExpression="idUsuario" />
            <asp:BoundField DataField="identificacion" HeaderText="Identificación" SortExpression="identificacion" >
            </asp:BoundField>
            <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" >
            </asp:BoundField>
            <asp:BoundField DataField="apellido" HeaderText="Apellido" SortExpression="apellido" >
            </asp:BoundField>
            <asp:BoundField DataField="tipoUsuario" HeaderText="Tipo usuario" SortExpression="tipoUsuario" >
            </asp:BoundField>
            <asp:CommandField HeaderText="Opción" SelectText="Editar" ShowSelectButton="True" />
        </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Lec05ConnectionString %>" SelectCommand="SELECT TipoUsuario.nombre AS tipoUsuario, Usuario.identificacion, Usuario.nombre, Usuario.apellido, Usuario.idUsuario FROM TipoUsuario INNER JOIN Usuario ON TipoUsuario.idTipoUsuario = Usuario.idTipoUsuario" OnSelecting="SqlDataSource1_Selecting" ProviderName="<%$ ConnectionStrings:Lec05ConnectionString.ProviderName %>"></asp:SqlDataSource>
    </div>
</asp:Content>
