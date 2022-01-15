<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="reporCurso_Docentes.aspx.cs" Inherits="UI.web_.Reportes.reportematerias" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <html >
    <head>
        <link href="estilos.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/html2pdf.js/0.10.1/html2pdf.bundle.min.js" integrity="sha512-GsLlZN/3F2ErC5ifS5QtgpiJtWd43JWSuIgh7mbzZ8zBps+dvLusV+eNQATqgA/HdeKFVgA5v3S/cIrLF7QnIg==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    </head>
    <body>
        <hr />
       <center> <h1>Profesores de cada curso</h1></center>
        <div>
    <center> <asp:GridView ID="gridview" CssClass="print"  runat="server"  OnPageIndexChanged="GridView1_SelectedIndexChanged">
    </asp:GridView> 
      
            </center>

     </div>
        <br />
        
        

    <center><asp:Button ID="Button2" runat="server" Text="Imprimir Informe " OnClientClick="imprime()" OnClick="Button2_Click" /> </center>
        <hr />
        <script src="CodigoParaImprimir.js"></script>
          

    </body>
    </html>
    
</asp:Content>
