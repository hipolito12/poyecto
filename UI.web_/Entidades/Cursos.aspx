<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.web_.Entidades.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <link href="Estilos/Cursos.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Dosis&display=swap" rel="stylesheet"/>
    <title></title>
</head>

<body>
    <div id="formulario">
           <form action="/" method="post" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Seleccione materias:   "></asp:Label > <asp:DropDownList ID="comboidmateria" runat="server" Height="25px" Width="211px" AutoPostBack="True">
                   <asp:ListItem>aa </asp:ListItem>
               </asp:DropDownList> <br />
               <br />
               <asp:Label ID="Label2" runat="server" Text="Seleccione comisiones:   ">         </asp:Label> <asp:DropDownList ID="comboComision" runat="server" Height="39px" Width="195px" AutoPostBack="True">
                   <asp:ListItem>bbb</asp:ListItem>
               </asp:DropDownList> <br />
               <br />
               <asp:Label ID="Label3" runat="server" Text="ingrese Año calendario:  ">        </asp:Label> <asp:TextBox ID="TxtAnio" runat="server"  CssClass="input_calendario" ></asp:TextBox> <br />
               <br />
                <asp:Label ID="Label4" runat="server" Text="Ingres cupo:     "></asp:Label>      <asp:TextBox ID="txtcupo" runat="server"   CssClass="input_cupo"></asp:TextBox> <br />
            
           
            <div id=" botones" >
            <asp:Button ID="btnagregar" runat="server" Text="Agregar "  />              
            <asp:Button ID="btneditar" runat="server" Text="Modificar "  />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar " />


        </div>
           
           </form>
       
  </div>
</body>

</html>
        
</asp:Content>
