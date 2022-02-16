<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="CursosEintegrantes.aspx.cs" Inherits="UI.web_.Reportes.CursosEintegrantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
        <center> 
        
            <h1>Reporte actual de Cursos</h1>
            <br />
            <div id="desaparecer">
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
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
            <br />
             <asp:Button ID="btnImprime" runat="server" Text="Imprimir" OnClick="btnImprime_Click"  CssClass="margen"/> 
        </center></div>

    <style>
        * {
            margin:0;
            
        }
        #desaparecer {
            text-align:center;
            margin-left:20em;
        }
        #desaparecer th:nth-child(1) 
        {
            display:none;
        }

        #desaparecer td:nth-child(1) 
        {
            display:none;
        }
        #desaparecer th:nth-child(2) {
        
          visibility:hidden;
        }
            #desaparecer th:nth-child(2)::after 
            {
                margin:0;
                content:"materias";
                visibility:visible;
                background-color:cornflowerblue;
                width:8em;
                padding-left : 1.4em;
                padding-right :4em;
                padding-top:0.5em;
                 padding-bottom:0.4em;
                margin-right:2em;
            }

            #desaparecer th:nth-child(3) {
            }

        .margen {
        margin-right:10em;}
    </style>

    <script src="CodigoParaImprimir.js"></script>
</asp:Content>
