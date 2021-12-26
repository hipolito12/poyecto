<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.web_.Login" %>




<asp:Content ID="contenido2" ContentPlaceHolderID="aa" runat="server">


    <!DOCTYPE html>

    <html>

    <head>
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" />
        <link href="../Entidades/Estilos/Login_styles.css" rel="stylesheet" />
        <link href="../Entidades/Estilos/personas.css" rel="stylesheet" />
    </head>
    <body>
        
 
            <div id="Login">
                
                <section id="seccion">
                    <asp:Label Text="Ingrese su usuario: " runat="server" />
                    &nbsp;<asp:TextBox ID="l" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label Text="Ingrese su Contraseña: " runat="server" />
                    <asp:TextBox ID="contrasena" runat="server"></asp:TextBox>
                    &nbsp;<br />
                 
                    <br />
                    <div id="botones">
                        <asp:LinkButton ID="boton_ingreso" CssClass="boton" runat="server" OnClick="boton_ingreso_Click">Ingresar</asp:LinkButton>
                        <asp:LinkButton ID="boton_registrarme" CssClass="boton" runat="server" OnClick="boton_registrarme_Click1">Registrarme</asp:LinkButton>



                    </div>
                    <br />
                    <br />
                </section>


                <strong> 
                    <asp:Label CssClass="superponer" ID="Mensaje_error" runat="server" Text="Constraseña o  Usuario incorrectos"></asp:Label>
                    <asp:Label CssClass="label_superpuesta" ID="Mensaje_campo_vacio" runat="server" Text="Veerifique su entrada"></asp:Label>
                    <asp:Label CssClass="label_superpuesta" ID="error" runat="server" Text="Ah ocurrdio un error,v"></asp:Label>
        
           </strong>
           </div>
     
       </form>
              
              
       
    </body>
    </html>











</asp:Content>

