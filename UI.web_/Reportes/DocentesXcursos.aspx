<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="DocentesXcursos.aspx.cs" Inherits="UI.web_.Reportes.DocentesXcursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
   <center>  

       <h1>Docentes de cada Curso</h1>

       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
           <AlternatingRowStyle BackColor="White" />
           <Columns>
               <asp:BoundField DataField="nombres" HeaderText="nombres" ReadOnly="True" SortExpression="nombres" />
               <asp:BoundField DataField="id_curso" HeaderText="id_curso" SortExpression="id_curso" />
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

       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tp2ConnectionString %>" SelectCommand="select   CONCAT( p.nombre , p.apellido) as nombres, dc.id_curso from   docentes_cursos dc inner join personas p on p.id_persona = dc.id_docente "></asp:SqlDataSource>

       <br />
       <br />

       <asp:Button ID="btnImprimir" runat="server" Text="Imprimir"  OnClick="btnImprimir_Click"  />
       <script src="CodigoParaImprimir.js"></script>
   </center>
</asp:Content>
