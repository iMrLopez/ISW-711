<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="InsertarRecreativa.aspx.cs" Inherits="examen1WebL.InsertarRecreativa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <p>Descripcion</p> <asp:TextBox ID="txtBDescripcion" runat="server" Width="563px" Height="46px" TextMode="MultiLine"></asp:TextBox>
       <br />
       <br />
       Tipo de Recreativa<br />
       <br />
       <asp:DropDownList ID="ddlTipo" runat="server" Height="16px" Width="379px">
       </asp:DropDownList>
       <br />
       <br />
       Kilometros<br />
       <br />
       <asp:TextBox ID="txtbKilometros" runat="server" TextMode="Number" Width="375px"></asp:TextBox>
       <br />
       <br />
       Costo por camiseta<br />
       <br />
       <asp:TextBox ID="txtbCosto" runat="server" TextMode="Number" Width="375px">0</asp:TextBox>
       <br />
       <br />
       Total<br />
       <br />
       <asp:TextBox ID="txtbTotal" runat="server" ReadOnly="True" TextMode="Number" Width="375px">0</asp:TextBox>
       <br />
       <br />
       <br />
       <asp:Button ID="btnProcesar" runat="server" OnClick="btnProcesar_Click" Text="Procesar" />
       <br />
</asp:Content>
