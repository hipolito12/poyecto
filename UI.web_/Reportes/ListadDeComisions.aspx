<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="ListadDeComisions.aspx.cs" Inherits="UI.web_.Reportes.Listado_de_cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <div id="mover">
<ceneter>
    <center><h1>Comisiones  </h1></center>
    <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="anio de la comision" HeaderText="anio de la comision" SortExpression="anio de la comision" />
                <asp:BoundField DataField="descripcion de comisiones" HeaderText="descripcion de comisiones" SortExpression="descripcion de comisiones" />
                <asp:BoundField DataField="descripcion del plan" HeaderText="descripcion del plan" SortExpression="descripcion del plan" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:thetrueconextion %>" SelectCommand="use[tp2] 
       SELECT c.anio_especialidad as &quot;anio de la comision&quot;,c.desc_comision  as &quot;descripcion de comisiones&quot; ,p.desc_plan as &quot;descripcion del plan&quot; from comisiones c
	   join planes p on p.id_plan = c.id_plan;"></asp:SqlDataSource>
    <br />
   <center> <asp:Button   runat="server" Text="Imprimir" ID="btnimprime" OnClick="Unnamed1_Click" onclientclick-="imprime()" /></ceneter></center>
</div>
    <style>

        table {
            text-align:center;
        }
     
        #mover 
        {
            margin-left:20%;
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

