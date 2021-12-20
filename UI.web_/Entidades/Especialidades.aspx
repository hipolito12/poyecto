<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.web_.Entidades.Especialidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
      


    <!DOCTYPE html>
    <html>

    <head>
        <meta charset="utf-8" />
        <link href="Estilos/especialidades.css" rel="stylesheet" />
        <title></title>
    </head>
    <body>

        <form id="form1" runat="server">
            <h3 id="subtittulo">Ingrese una descripcion de la espacialdiad</h3>
            <br />
            <asp:TextBox ID="Txtdescripcion"   CssClass="Txtdescripcion"     runat="server" Height="220px" Width="524px"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="especialidadgv"  CssClass="especialidadgv"  runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="especialidadgv_SelectedIndexChanged">
                <SelectedRowStyle BorderColor="#FF99FF" />
            </asp:GridView>
           
            <div  class="botones">
                
                <asp:Button ID="txtAlta" runat="server" Text="Agregar" OnClick="txtAlta_Click" />
                <asp:Button ID="txtmodificacion" runat="server" Text="Modificar" OnClick="txtmodificacion_Click" />
                <asp:Button ID="txteliminar" runat="server" Text="Eliminar" OnClick="txteliminar_Click" />

            </div>
             <span> <asp:Label ID="error" runat="server" Text="Ocurrio un error! verifique su entrada"></asp:Label> </span>
        </form>
    </body>
    </html>
      



</asp:Content>
