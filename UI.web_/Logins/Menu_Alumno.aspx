<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Menu_Alumno.aspx.cs" Inherits="UI.web_.Logins.Menu_Alumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    
    
   
  <!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <link href="../Entidades/Estilos/Menu_Alumnos.css" rel="stylesheet" />
    <title></title>
</head>
<body>
      <h2 style="font-size:3em; color:darkblue ;     margin-left :30%; ">Seleccione una opcion </h2>
    <div id="listas">
        <ul>
            <li><a href="../Entidades/Comisiones.aspx">Comision</a></li>
            <li><a href="../Entidades/Cursos.aspx">Curso</a></li>
            <li><a href="../Entidades/Materias.aspx">Materia</a></li>
            <li><a href="../Entidades/Modulos.aspx">Modulos</a></li>
            <li><a href="../Entidades/alumnos_inscripcioness.aspx">Alumnos e inscripciones</a></li>
        </ul>


    </div>
</body>
</html>
    



</asp:Content>
