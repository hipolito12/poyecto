<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Menu_Profesores.aspx.cs" Inherits="UI.web_.Logins.Menu_Profesores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <link href="../Entidades/Estilos/Menu-profesores.css" rel="stylesheet" />
     <h2 style="font-size:3em; color:darkblue ;     margin-left :30%; ">Seleccione una opcion </h2>
    <div id="listas">
        <ul>
            
             <li><a href="../Entidades/planes.aspx">Planes</a></li>
             <li><a href="../Reportes/Calificar_alumnos.aspx">Colocar notas</a></li>
              <li><a href="../Reportes/DocentesXcursos.aspx">Docentes de cada curso</a></li>
              <li><a href="../Reportes/ListadDeComisions.aspx">Listado de comisiones</a></li>
            <li><a href="../Reportes/CantidadAlumnosXcurso.aspx">Cantidad de alumnos en comisiones</a></li>


                       
        </ul>


    </div>

</asp:Content>
