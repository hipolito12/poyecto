<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="planes.aspx.cs" Inherits="UI.web_.Entidades.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <link href="Estilos/Planes.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form action="/" method="post" >

    <div class="posicion">
    <asp:Label ID="Label1" runat="server" Text="Ingrese descripcion del plan  :  "    CssClass="descripcion_titulo"></asp:Label>
    <br />
    <asp:TextBox ID="Txtplan" CssClass="descripcion"  runat ="server" Height="152px" Width="526px"></asp:TextBox>
    <br />
    <br />
<asp:Label ID="Label2" runat="server" Text="Selecione una especialidad :  "></asp:Label>    <asp:DropDownList ID="Ddlespecialidad" runat="server" Width="210px"></asp:DropDownList>
    <br />
    <br />
</div>




    <asp:GridView ID="gv"  CssClass="gv"   runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gv_SelectedIndexChanged">
        <SelectedRowStyle BorderColor="#CC0000" BorderStyle="Solid" BorderWidth="3px" />
    </asp:GridView>
    <br />
        
    <br />
    <div class="botones">
        <asp:Button ID="btnagregar" runat="server" Text="Agregar "  CssClass="boton"  OnClick="btnagregar_Click"  />              
            <asp:Button ID="btneditar" runat="server" Text="Modificar "  CssClass="boton" OnClick="btneditar_Click"  />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar " OnClick="btnEliminar_Click" />
          
    </div>
     <asp:Label ID="error" runat="server" Text="ah ocurrido un error" CssClass="error"></asp:Label>
        </form>
</body>
</html>
</asp:Content>
