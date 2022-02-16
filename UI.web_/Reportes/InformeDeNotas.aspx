<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="InformeDeNotas.aspx.cs" Inherits="UI.web_.Reportes.InformeDeNotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <center>
        <h1>Notas</h1>
        <asp:Label ID="Label1" runat="server" Text="Ingrese su curso"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlCursos" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="desc_materia" DataValueField="desc_materia" Width="256px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:thetrueconextion %>" SelectCommand="select m.desc_materia from alumnos_inscripciones ai
join cursos c on c.id_curso = ai.id_curso 
join materias m on m.id_materia = c.id_materia 
where ai.id_alumno = @param;">
            <SelectParameters>
                <asp:SessionParameter Name="param" SessionField="usuario" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="Black" GridLines="Horizontal">
            <Columns>
                <asp:BoundField DataField="nota" HeaderText="nota" SortExpression="nota" />
                <asp:BoundField DataField="condicion" HeaderText="condicion" SortExpression="condicion" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:thetrueconextion %>" SelectCommand="select ai.nota,ai.condicion from  alumnos_inscripciones ai
join cursos c on ai.id_curso = c.id_curso
join materias m on m.id_materia = c.id_materia
where c.anio_calendario = YEAR(GETDATE())
and ai.id_alumno =@alumno
and m.desc_materia = @param2;
">
            <SelectParameters>
                <asp:SessionParameter Name="alumno" SessionField="usuario" />
                <asp:ControlParameter ControlID="ddlCursos" Name="param2" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <script src="CodigoParaImprimir.js"></script>
    <asp:Button ID="btnAceptar" runat="server" Text="Imprimir" OnClick="btnAceptar_Click"  OnClientClick="imprime()"  />
    </center>
    <hr />
</asp:Content>
