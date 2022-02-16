<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="reporteMATERIAS.aspx.cs" Inherits="UI.web_.Reportes.reporteMATERIAS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    
    <center> 

        <h1>Informacion de Materias</h1>
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
        <br />
        
        <asp:Button ID="btnimprimir" runat="server" Text="Imprimir" OnClick="btnimprimir_Click" />

        </div>
        <script src="CodigoParaImprimir.js"></script>
    </center>

    <style  >
        #desaparecer { padding:0;
        }
        #desaparecer th:nth-child(2) {
            display: none;
        }

        #desaparecer td:nth-child(2) {
            display: none;
        }

         #desaparecer th:nth-child(1) {
            display: none;
        }

        #desaparecer td:nth-child(1) {
            display: none;
        }

        #desaparecer tr th:nth-child(4) {
            visibility:hidden;
        }

         #desaparecer tr th:nth-child(4)::after { 
             content:" horas semanales";
              visibility:visible;
              width:10em;

      
        }
            #desaparecer tr th:nth-child(4)::after {
                float:left;
                background-color:cornflowerblue;
                height:2em;
                margin-left:5em;
                text-align:center;
                padding:-2em;
            }

             #desaparecer  tr td:nth-child(4)
             {
                text-align:center;
             }

        </style>


</asp:Content>
