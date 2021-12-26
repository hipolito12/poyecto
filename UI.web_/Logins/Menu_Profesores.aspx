<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Menu_Profesores.aspx.cs" Inherits="UI.web_.Logins.Menu_Profesores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <link href="../Entidades/Estilos/Menu-profesores.css" rel="stylesheet" />
     <h2 style="font-size:3em; color:darkblue ;     margin-left :30%; ">Seleccione una opcion </h2>
    <div id="listas">
        <ul>
            <li><a href="../Entidades/Comisiones.aspx">Comision</a></li>
            <li><a href="../Entidades/Cursos.aspx">Curso</a></li>
            <li><a href="../Entidades/Materias.aspx">Materia</a></li>
            <li><a href="../Entidades/Modulos.aspx">Modulos</a></li>
            <li><a href="../Entidades/alumnos_inscripcioness.aspx">Alumnos e inscripciones</a></li>
            <li><a href="../Entidades/docentes-cursos.aspx">Docente y cursos</a></li>
            <li><a href="../Entidades/Especialidades.aspx">Especialdiades</a></li>
             <li><a href="../Entidades/planes.aspx">Planes</a></li>
                       
        </ul>


    </div>

</asp:Content>
