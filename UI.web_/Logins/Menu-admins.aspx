<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Menu-admins.aspx.cs" Inherits="UI.web_.Logins.Menu_admins" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    
   
    <link href="../Entidades/Estilos/Menu_Admins%20-%20Copia.css" rel="stylesheet" />
      <h2 style="font-size:3em; color:darkblue ;     margin-left :30%; ">Seleccione una opcion </h2>
    <div id="listas">
        <ul>
            
            <li><a href="../Entidades/Comisiones.aspx">Comision</a></li>
            <li><a href="../Entidades/Cursos.aspx">Curso</a></li>
            <li><a href="../Entidades/Materias.aspx">Materia</a></li>
            <li><a href="../Entidades/Modulos.aspx">Modulos</a></li>
            <li><a href="../Entidades/alumnos_inscripcioness.aspx">Alumnos e inscripciones</a></li>
            <li><a href="../Entidades/docentes_curso.aspx">Docente y cursos</a></li>
            <li><a href="../Entidades/Especialidades.aspx">Especialdiades</a></li>
            <li><a href="../Entidades/Personas.aspx">Personas</a> </li>
            <li><a href="../Entidades/Usuario.aspx">Usuarios</a></li>
             <li><a href="../Entidades/planes.aspx">Planes</a></li>
            <li><a href="../Reportes/CursosEintegrantes.aspx">reporte de Cursos e integrantes</a></li>
                       
        </ul>


    </div>
</asp:Content>
