<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="ListadDeComisions.aspx.cs" Inherits="UI.web_.Reportes.Listado_de_cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <div id="mover">
<ceneter>
    <h1>Comisiones  </h1>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id_comision" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id_comision" HeaderText="id_comision" InsertVisible="False" ReadOnly="True" SortExpression="id_comision" />
            <asp:BoundField DataField="desc_comision" HeaderText="desc_comision" SortExpression="desc_comision" />
            <asp:BoundField DataField="anio_especialidad" HeaderText="anio_especialidad" SortExpression="anio_especialidad" />
            <asp:BoundField DataField="id_plan" HeaderText="id_plan" SortExpression="id_plan" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tp2ConnectionString %>" SelectCommand="SELECT [id_comision], [desc_comision], [anio_especialidad], [id_plan] FROM [comisiones]"></asp:SqlDataSource>
    <br />
    <asp:Button   runat="server" Text="Imprimir" ID="btnimprime" OnClick="Unnamed1_Click" onclientclick-="imprime()" /></ceneter>
</div>
    <style>

     
        #mover 
        {
            margin-left:30%;
        }

           #mover > h1 
        {
            text-align:center;
        }
            #mover >
            button 
            {
                margin-left :35%;
            }
    </style>

    <script src="CodigoParaImprimir.js"></script>
</asp:Content>

