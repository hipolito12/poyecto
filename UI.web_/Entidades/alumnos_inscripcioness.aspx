<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="alumnos_inscripcioness.aspx.cs" Inherits="UI.web_.Entidades.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">

     <link href="Estilos/alumnos_inscripciones.css" rel="stylesheet" />
    
    <form  method="post" runat="server" >
    <div class="acomodar">
    <asp:Label ID="Label2" runat="server" Text="Ingrese Estado del alumno : "></asp:Label><asp:TextBox ID="Txtalumno" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Ingrese nota: "></asp:Label><asp:TextBox ID="Txtnota" runat="server" Width="152px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Seleccione el Curso :   "></asp:Label> <asp:DropDownList ID="ddlcurso" runat="server" Width="189px"></asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Seleccione el Alumno :   "></asp:Label> <asp:DropDownList ID="ddlalumno" runat="server" Width="189px"></asp:DropDownList>
        </div>
    <br />
    <br />
    
    <asp:GridView ID="GridView1"   runat="server"  AutoGenerateSelectButton="True"  CssClass="gv" Height="173px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="448px">
        <SelectedRowStyle BackColor="#99FFCC" />
    </asp:GridView>
    <br />
    <br />

    <div class="botones">
        <asp:Button ID="btnagregar" runat="server" Text="agregar" OnClick="btnagregar_Click1" />
        <asp:Button ID="Btneditar" runat="server" Text="Modificar"  CssClass="boton" OnClick="Btneditar_Click" />
        <asp:Button ID="Btneliminar" runat="server" Text="Eliminar" OnClick="Btneliminar_Click" />
    </div>
     <asp:Label ID="error" runat="server" Text="AH ocurrido  un error! " CssClass="error"></asp:Label>
        <br />
        </form>
</asp:Content>
