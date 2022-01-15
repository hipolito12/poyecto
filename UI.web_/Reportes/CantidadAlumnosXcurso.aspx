<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="CantidadAlumnosXcurso.aspx.cs" Inherits="UI.web_.Reportes.CantidadAlumnosXcurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <center > 
        <h1> Alumnos en cada curso </h1>
        <br />

        <asp:GridView runat="server" ID="galumnosXcursos" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id_curso" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id_curso" HeaderText="id_curso" InsertVisible="False" ReadOnly="True" SortExpression="id_curso" />
                <asp:BoundField DataField="alumnos" HeaderText="alumnos" ReadOnly="True" SortExpression="alumnos" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tp2ConnectionString %>" SelectCommand="use[tp2] 
              select c.id_curso,  count (ai.id_alumno)as alumnos from alumnos_inscripciones ai 
                join cursos c on c.id_curso = ai.id_curso
              
                 group by c.id_curso  ;"></asp:SqlDataSource>
        <br />
        <asp:Button runat="server" Text="Imprimir" ID="btnImprimir" OnClick="btnImprimir_Click" onclientClick="imprime()"  />
        <script src="CodigoParaImprimir.js"></script>
    </center>
</asp:Content>
