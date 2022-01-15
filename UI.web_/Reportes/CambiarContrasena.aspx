<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="CambiarContrasena.aspx.cs" Inherits="UI.web_.Reportes.CambiarContrasena" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <center>
    <asp:Label ID="lblactual" runat="server" Text="Ingrese contraeña actual" Font-Bold="True"></asp:Label>
    <br />
    <asp:TextBox ID="txtactual" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblnueva" runat="server" Text="Ingrese Nueva contraeña" Font-Bold="True"></asp:Label>
        <br />
    <br />
    <asp:TextBox ID="txtnueva" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblnuevamentre" runat="server" Text="ingrese nuevamente " Font-Bold="True"></asp:Label>
        <br />
    <br />
    <asp:TextBox ID="txtnuevamente" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btncambiar" runat="server" OnClick="btncambiar_Click" Text="Cambiar" />
        <br />
        <asp:Label ID="lblinformar" runat="server" Text="Label" Visible="False"></asp:Label>
    <br /> </center>  
</asp:Content>
