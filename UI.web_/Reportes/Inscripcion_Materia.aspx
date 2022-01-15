<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Inscripcion_Materia.aspx.cs" Inherits="UI.web_.Reportes.Inscripcion_Materia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <center>  
        <h1>Selecione el curso  para registrarse </h1>
    <asp:DropDownList ID="DropDownList1" runat="server" Width="442px" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="id_curso" DataValueField="id_curso">
    </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tp2ConnectionString %>" SelectCommand="SELECT [id_curso] FROM [cursos]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="cupos restantes" HeaderText="cupos restantes" ReadOnly="True" SortExpression="cupos restantes" />
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
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:tp2ConnectionString %>" SelectCommand="

select   concat( 'Cupos restantes: ',c.cupo - (select count(ai.id_alumno)  from alumnos_inscripciones ai where ai.id_curso =@param))as 'cupos restantes' from cursos c 



where c.id_curso =@param ;">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="0" Name="param" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Button ID="btnInscribirme" runat="server" OnClick="Button2_Click" Text="Inscribirme" />
        <br />
        <asp:Label ID="lblestado" runat="server" Text="Label"></asp:Label>
        <br />
    </center>
</asp:Content>
