<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.web_.Entidades.Personas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    

    <link href="Estilos/personas.css" rel="stylesheet" />
  
        <div class=" acomodar">
            <asp:Label ID="Label1" runat="server" Text="Ingrese nombre  : " CssClass="separar"></asp:Label>
            <asp:TextBox ID="Txtnombre" runat="server"></asp:TextBox>

            <asp:Label ID="Label2" runat="server" Text="Ingrese apellido : " CssClass="separar"></asp:Label><asp:TextBox ID="Txtapellido" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Ingrese direccion :" CssClass="separar"></asp:Label>
            <asp:TextBox ID="Txtdireccion" runat="server"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Ingrese email : " CssClass="separar"></asp:Label>
            <asp:TextBox ID="Txtemail" runat="server" Width="246px"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Ingrese telefono" CssClass="separar"></asp:Label>
            <asp:TextBox ID="Txttelefono" runat="server"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="Ingreso fecha de nacimiento :" CssClass="separar"></asp:Label>
            <asp:TextBox ID="Txtnacimiento" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Ingrese su Legajo" CssClass="separar"></asp:Label>
            <asp:TextBox ID="Txtlegajo" runat="server"></asp:TextBox>
            <asp:Label ID="Label8" runat="server" Text=" Seleccione Tipo persona :" CssClass="separar"></asp:Label>
            <asp:DropDownList ID="ddltipo" runat="server">
                <asp:ListItem Value="1">Profesor</asp:ListItem>
                <asp:ListItem Value="0">Administrador</asp:ListItem>
                <asp:ListItem Value="2">Alumno</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Seleccione plan :" CssClass="separar"> </asp:Label>
            <asp:DropDownList ID="Ddlplan" runat="server"></asp:DropDownList>
        </div>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="gv" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <SelectedRowStyle BorderColor="#FF0066" />
        </asp:GridView>

        <br />

        <div class=" botones">

            <asp:Button ID="btnagregar" runat="server" Text="Agregar " OnClick="btnagregar_Click" CssClass="boton" />
            <asp:Button ID="btneditar" runat="server" Text="Modificar " OnClick="btneditar_Click" CssClass="boton" Height="45px" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar " OnClick="btnEliminar_Click" />


        </div>
        <asp:Label ID="Error" runat="server" CssClass="error" Text="AH ocurrido un error!"></asp:Label>

   

</asp:Content>
