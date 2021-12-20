<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="docentes-curso.aspx.cs" Inherits="UI.web_.Entidades.docentes_curso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <form id="form1" runat="server">
    <!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <link href="Estilos/docentes-curso.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div class="posicionar">
    <asp:Label ID="Label1" runat="server" Text="Seleccione curso: "></asp:Label>   
    <asp:DropDownList ID="ddlcurso" runat="server" Width="168px"> </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Seleccione un docente"></asp:Label>   :
    <asp:DropDownList ID="ddldocente" runat="server" Width="174px"> </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="   Ingrese cargo : "></asp:Label>  <asp:TextBox ID="Txtcargo" runat="server" Width="238px"></asp:TextBox>
    <br />
    <br />
        </div>
    <asp:GridView ID="gv" CssClass="gv" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <SelectedRowStyle ForeColor="#FFCCCC" />
    </asp:GridView>
    <br />
    <br />
   

    <div class="botones">

        <asp:Button ID="btncarga"  CssClass="btnagregar"  runat="server" Text="Agregar" OnClick="btncarga_Click" />
        <asp:Button ID="btnmodificacion" runat="server" CssClass="btnmodificacion" Text="Modificar" OnClick="btnmodificacion_Click" />
        <asp:Button ID="Btneliminar" runat="server" Text="Eliminar" OnClick="Btneliminar_Click" />

    </div>

    <span> <asp:Label ID="error" runat="server" Text="Ha ocurrido un error"></asp:Label>
    </span>

</body>
</html>
    </form>
</asp:Content>
