<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="InformeDeNotas.aspx.cs" Inherits="UI.web_.Reportes.InformeDeNotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <center>
        <h1>Notas</h1>
        <asp:Label ID="Label1" runat="server" Text="Ingrese su curso"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlCursos" runat="server" OnSelectedIndexChanged="ddlCursos_SelectedIndexChanged" DataSourceID="SqlDataSource1" DataTextField="anio_calendario" DataValueField="anio_calendario" Width="331px">
            <asp:ListItem>asa</asp:ListItem>
    </asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tp2ConnectionString %>" SelectCommand="SELECT [anio_calendario] FROM [cursos]"></asp:SqlDataSource>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:BoundField DataField="nota" HeaderText="nota" SortExpression="nota" />
            <asp:BoundField DataField="condicion" HeaderText="condicion" SortExpression="condicion" />
        </Columns>
    </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:tp2ConnectionString %>" SelectCommand="select ai.nota,ai.condicion from  alumnos_inscripciones ai
join cursos c on ai.id_curso = c.id_curso
join materias m on m.id_materia = c.id_materia
where c.anio_calendario =@anio 
and ai.id_alumno =@alumno ">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlCursos" DefaultValue="0" Name="anio" PropertyName="SelectedValue" Type="Int32" />
                <asp:SessionParameter DefaultValue="0" Name="alumno" SessionField="usuario" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
    <asp:Button ID="btnAceptar" runat="server" Text="Imprimir" OnClick="btnAceptar_Click"  OnClientClick="imprime()"  />
        <script src="CodigoParaImprimir.js"></script>
        <asp:Button ID="Button2" runat="server" Text="Aceptar" />
    </center>
    <hr />
</asp:Content>
