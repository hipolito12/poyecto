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
     <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"/>
    <title></title>
</head>

<body>
    <div id="formulario">
            <asp:Label ID="Label1" runat="server" Text="Seleccione materias:   "></asp:Label > <asp:DropDownList ID="comboidmateria" runat="server" Height="25px" Width="211px" AutoPostBack="True" OnSelectedIndexChanged="comboidmateria_SelectedIndexChanged">
               </asp:DropDownList> <br />
               <br />
               <asp:Label ID="Label2" runat="server" Text="Seleccione comisiones:   ">         </asp:Label> 
            <asp:DropDownList ID="comboComision" runat="server" Width="207px">
            </asp:DropDownList>
            <br />
               <br />
               <asp:Label ID="Label3" runat="server" Text="ingrese Año calendario:  ">        </asp:Label> <asp:TextBox ID="TxtAnio" runat="server"  CssClass="input_calendario" ></asp:TextBox> <br />
               <br />
                <asp:Label ID="Label4" runat="server" Text="Ingres cupo:     "></asp:Label>      <asp:TextBox ID="txtcupo" runat="server"   CssClass="input_cupo"></asp:TextBox> 
               <br />
               <br />

               <asp:GridView CssClass="gridStyles" ID ="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">

               </asp:GridView>
               <br />
            
               <asp:Label ID="error" runat="server" Text=" ah ocurrido un error!" CssClass="errores animate__shakeY" ></asp:Label>
            <div class=" botones" >
             
            <asp:Button ID="btnagregar" runat="server" Text="Agregar "  CssClass="boton" OnClick="btnagregar_Click"  />              
            <asp:Button ID="btneditar" runat="server" Text="Modificar " OnClick="btneditar_Click" CssClass="boton" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar " OnClick="btnEliminar_Click" />


        </div>
           
           
       
  </div>
</body>

</html>
        
</asp:Content>
