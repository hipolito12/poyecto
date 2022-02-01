<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="reporteMATERIAS.aspx.cs" Inherits="UI.web_.Reportes.reporteMATERIAS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    
    <center> 
        <h1>Informacion de Materias</h1>
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_plan" DataSourceID="SqlDataSource1" AllowSorting="True" Height="250px">
         <Columns>
             <asp:BoundField DataField="desc_materia" HeaderText="desc_materia" SortExpression="desc_materia" />
             <asp:BoundField DataField="hs_totales" HeaderText="hs_totales" SortExpression="hs_totales" />
             <asp:BoundField DataField="hs_semanales" HeaderText="hs_semanales" SortExpression="hs_semanales" />
             <asp:BoundField DataField="id_plan" HeaderText="id_plan" InsertVisible="False" ReadOnly="True" SortExpression="id_plan" />
         </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tp2ConnectionString %>" SelectCommand="use tp2
select * from materias">
            <SelectParameters>
                <asp:SessionParameter Name="personas" SessionField="usuario" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        
        <asp:Button ID="btnimprimir" runat="server" Text="Imprimir" OnClick="btnimprimir_Click" />
        <script src="CodigoParaImprimir.js"></script>
    </center>

</asp:Content>
