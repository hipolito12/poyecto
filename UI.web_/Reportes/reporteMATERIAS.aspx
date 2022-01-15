<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="reporteMATERIAS.aspx.cs" Inherits="UI.web_.Reportes.reporteMATERIAS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" >

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <center>
        <h1>Materias</h1>
    </center>
    <div CLASS="print">
    <center> <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
       <Columns>
           <asp:BoundField DataField="desc_materia" HeaderText="desc_materia" SortExpression="desc_materia" />
           <asp:BoundField DataField="hs_semanales" HeaderText="hs_semanales" SortExpression="hs_semanales" />
           <asp:BoundField DataField="hs_totales" HeaderText="hs_totales" SortExpression="hs_totales" />
           <asp:BoundField DataField="id_plan" HeaderText="id_plan" SortExpression="id_plan" />
       </Columns>
    </asp:GridView>
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tp2ConnectionString %>" SelectCommand="SELECT [desc_materia], [hs_semanales], [hs_totales], [id_plan] FROM [materias] ORDER BY [hs_totales], [hs_semanales]"></asp:SqlDataSource>
       <br />
        </div></center>
  <center>  <asp:Button ID="Button2" runat="server" Text="Imprimir" OnClick="Button2_Click"  OnClientClick="imprime()" /> </center>

       <script src="https://cdnjs.cloudflare.com/ajax/libs/html2pdf.js/0.10.1/html2pdf.bundle.min.js" integrity="sha512-GsLlZN/3F2ErC5ifS5QtgpiJtWd43JWSuIgh7mbzZ8zBps+dvLusV+eNQATqgA/HdeKFVgA5v3S/cIrLF7QnIg==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <script src="CodigoParaImprimir.js"></script>
    <hr />
</asp:Content>
