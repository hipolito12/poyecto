<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.web_.Entidades.Estilos.Materias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <form id="form1" runat="server">
  <!DOCTYPE html>
       
<html>
<head>
    <meta charset="utf-8" />
    <link href="Materias.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div class="acomodar">
    <asp:Label ID="Label2" runat="server" Text="Ingrese decripcion de la materia : "></asp:Label><asp:TextBox ID="Txtdescripcion" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Ingrese Hs semanales : "></asp:Label><asp:TextBox ID="Txtsemanales" runat="server" Width="152px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Ingrese Hs totales : "></asp:Label><asp:TextBox ID="Txttotales" runat="server" Width="196px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Seleccione el plan :   "></asp:Label> <asp:DropDownList ID="ddlplan" runat="server" Width="189px"></asp:DropDownList>
        </div>
    <br />
    <br />
    
    <asp:GridView ID="GridView1"   runat="server"  AutoGenerateSelectButton="True"  CssClass="gv" Height="173px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="448px">
        <SelectedRowStyle BackColor="#99FFCC" />
    </asp:GridView>
    <br />
    <br />

    <div class="botones">
        <asp:Button ID="btnagregar" runat="server" Text="Agregar"  CssClass="boton" />
        <asp:Button ID="Btneditar" runat="server" Text="Modificar"  CssClass="boton" />
        <asp:Button ID="Btneliminar" runat="server" Text="Eliminar" />
    </div>
</body>
</html>
        <br />
    </form>
</asp:Content>
