   <%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Calificar_alumnos.aspx.cs" Inherits="UI.web_.Reportes.Calificar_alumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <center> 
        <br />
        <asp:Label ID="Label2" runat="server" Text="Seleccione curso" Font-Bold="True"></asp:Label>

    <br />

        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="desc_materia" DataValueField="id_curso" Width="313px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:thetrueconextion %>" SelectCommand="SELECT m.desc_materia ,c.id_curso FROM  cursos c
join materias m  on m.id_materia = c.id_materia
join docentes_cursos dc on dc.id_curso = c.id_curso
join personas per on per.id_persona = dc.id_docente
where c.anio_calendario = year(getdate())
and per.id_persona = @idper;">
            <SelectParameters>
                <asp:SessionParameter Name="idper" SessionField="usuarioprofe" />
            </SelectParameters>
        </asp:SqlDataSource>

    <br>
        <asp:Label ID="lblCondicion" runat="server" Text="Seleccione Condicion del alumno" Font-Bold="True"></asp:Label>
        <br />
     <asp:DropDownList ID="DropDownList2" runat="server" Width="313px" AutoPostBack="True">
         <asp:ListItem>Aprobacion directa</asp:ListItem>
         <asp:ListItem>Libre</asp:ListItem>
         <asp:ListItem>Aprobado</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
        <asp:Label ID="Label3" runat="server" Text="Ingrese Nota del alumno" Font-Bold="True"></asp:Label>
        <br />
    <asp:TextBox ID="txtnota" runat="server"></asp:TextBox>
    

        <br />
    

    <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:tp2ConnectionString %>" SelectCommand="select distinct CONCAT( p.nombre ,' ', p.apellido) as 'nombre',p.legajo
, m.desc_materia as 'materia' , ai.condicion , ai.nota from alumnos_inscripciones ai
join personas p on p.id_persona = ai.id_alumno
join cursos c on c.id_curso = ai.id_curso
join materias m on m.id_materia = c.id_materia
where ai.id_curso = @cur
and 
ai.nota= -1  and ai.condicion = ' ';">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="0" Name="cur" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
        <br />
        <asp:Label ID="lblinformar" runat="server" Text="Label"></asp:Label>
    <br />
</center>  
</asp:Content>
