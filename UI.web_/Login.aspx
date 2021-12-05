<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.web_.Login" %>




<asp:Content ID="contenido2" ContentPlaceHolderID="aa" runat="server"> 
 
      <!DOCTYPE html>

<html>
       
<head >
    
   
     
</head>
<body>
    <div id="Login">
           <section id="seccion">
      <asp:Label Text="Ingrese su usuario: " runat="server"  /> <input ID="l" type="text"/> <br />
       <asp:Label Text="Ingrese su Contraseña: " runat="server" /> <input  type="password"/>
        <br/>
        <br />
      <div id="botones">
     <a class="boton_personalizado"  id="test">Ingresar</a> 
     <a class="boton_personalizado" >Registrarse</a>
     </div>
               </section>
                 </div>
</body>
</html>





</asp:Content>

