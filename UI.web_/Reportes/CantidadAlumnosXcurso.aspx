<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="CantidadAlumnosXcurso.aspx.cs" Inherits="UI.web_.Reportes.CantidadAlumnosXcurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <center > 
        <h1> Alumnos en cada curso </h1>
        <br />

        <asp:GridView runat="server" ID="galumnosXcursos" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="masteria" HeaderText="masteria" SortExpression="masteria" />
                <asp:BoundField DataField="cantidad de inscriptos" HeaderText="cantidad de inscriptos" ReadOnly="True" SortExpression="cantidad de inscriptos" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tp2ConnectionString2 %>" SelectCommand="use[tp2] 
              select m.desc_materia as masteria,  count (ai.id_alumno)as &quot;cantidad de inscriptos&quot; from alumnos_inscripciones ai 
                join cursos c on c.id_curso = ai.id_curso
				join materias m  on m.id_materia =c.id_materia
                 group by m.desc_materia  ;"></asp:SqlDataSource>
        <br />
        <asp:Button runat="server" Text="Imprimir" ID="btnImprimir" OnClick="btnImprimir_Click" onclientClick="imprime()"  />
        <script src="CodigoParaImprimir.js"></script>



    </center>

    <style> table {text-align:center;}

    </style>

</asp:Content>
