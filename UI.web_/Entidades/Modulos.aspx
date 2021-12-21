<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UI.web_.Entidades.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
  <!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <link href="Estilos/Modulos.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div class="inputs">
    <asp:Label ID="Label1" runat="server" Text="Ingrese descripcion del modulo:  "></asp:Label><asp:TextBox ID="txtdescripcion" runat="server" Height="48px" Width="213px"></asp:TextBox>
    <br />
    <br />

    <asp:Label ID="Label2" runat="server" Text="Ingrese que ejecuta:   "></asp:Label><asp:TextBox ID="txtejecuta" runat="server" Height="44px" Width="251px"></asp:TextBox>
    <br />
    <br />
        </div>
    <asp:GridView ID="gv" CssClass="gv" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gv_SelectedIndexChanged">
        <SelectedRowStyle  ForeColor="#99FF99" />
    </asp:GridView>
    <br />
    <br />
    <div class="botones">
        <asp:Button ID="btnalta" runat="server" CssClass="posicionar" Text="Agregar" OnClick="btnalta_Click" />
        <asp:Button ID="btnModficaion" runat="server" Text="Modificar"  CssClass="posicionar" OnClick="btnModficaion_Click" />
        <asp:Button ID="Btneliminar" runat="server" Text="Eliminar" OnClick="Btneliminar_Click" />
        <br />
        <asp:Label ID="error"  CssClass="error"  runat="server" Text="Ha ocurrido un error   "/>
    </div>
    
</body>
</html>
</asp:Content>
