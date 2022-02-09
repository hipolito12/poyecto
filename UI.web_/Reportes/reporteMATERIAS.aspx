<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="reporteMATERIAS.aspx.cs" Inherits="UI.web_.Reportes.reporteMATERIAS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    
    <center> 

        <h1>Informacion de Materias</h1>
        <div id="desaparecer">
     <asp:GridView ID="GridView1" runat="server" AllowSorting="True" Height="250px">
        </asp:GridView>
        <br />
        <br />
        
        <asp:Button ID="btnimprimir" runat="server" Text="Imprimir" OnClick="btnimprimir_Click" />

        </div>
        <script src="CodigoParaImprimir.js"></script>
    </center>

    <style  >

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

        </style>


</asp:Content>
