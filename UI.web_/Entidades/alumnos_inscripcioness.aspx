<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="alumnos_inscripcioness.aspx.cs" Inherits="UI.web_.Entidades.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">

     <link href="Estilos/alumnos_inscripciones.css" rel="stylesheet" />
    
    
    <div class="acomodar">
    <asp:Label ID="Label2" runat="server" Text="Ingrese Estado del alumno : "></asp:Label>
        <asp:DropDownList ID="ddlestado" runat="server" Width="281px">
            <asp:ListItem>Inscripto</asp:ListItem>
            <asp:ListItem>Aprobado</asp:ListItem>
            <asp:ListItem>Libre</asp:ListItem>
            <asp:ListItem>Aprobacion directa</asp:ListItem>
        </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Ingrese nota: "></asp:Label><asp:TextBox ID="Txtnota" runat="server" Width="167px" Height="32px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Seleccione el Curso :   "></asp:Label> <asp:DropDownList ID="ddlcurso" runat="server" Width="189px" DataSourceID="SqlDataSource1" DataTextField="desc_materia" DataValueField="id_curso"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:thetrueconextion %>" SelectCommand="use tp2
Select CONCAT(p.nombre,' ',p.apellido) as 'nombre', p.id_persona as 'personas' from personas p where tipo_persona=2"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:thetrueconextion %>" SelectCommand="use tp2
 select distinct concat('curso:' ,m.desc_materia, '  ', 'comision',com.desc_comision ) as'desc_materia', c.id_curso
 from cursos c  
 join materias m on m.id_materia = c.id_materia
 join comisiones com on c.id_comision = com.id_comision
 where anio_calendario = YEAR(GETDATE())"></asp:SqlDataSource>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Seleccione el Alumno :   "></asp:Label> <asp:DropDownList ID="ddlalumno" runat="server" Width="189px" DataSourceID="SqlDataSource2" DataTextField="nombre" DataValueField="personas"></asp:DropDownList>
        </div>
    <br />
    <br />
    
    <asp:GridView ID="GridView1"   runat="server"  AutoGenerateSelectButton="True"  CssClass="gv" Height="173px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="448px">
        <SelectedRowStyle BackColor="#99FFCC" />
    </asp:GridView>
    <br />
    <br />

    <div class="botones">
        <asp:Button ID="btnagregar" runat="server" Text="agregar" OnClick="btnagregar_Click1" />
        <asp:Button ID="Btneditar" runat="server" Text="Modificar"  CssClass="boton" OnClick="Btneditar_Click" />
        <asp:Button ID="Btneliminar" runat="server" Text="Eliminar" OnClick="Btneliminar_Click" />
    </div>
     <asp:Label ID="error" runat="server" Text="Ha  ocurrido  un error! " CssClass="error"></asp:Label>
        <br />
</asp:Content>
