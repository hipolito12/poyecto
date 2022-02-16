<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="UI.web_.Entidades.Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <link href="Estilos/Usuario.css" rel="stylesheet" />
    <div class=" acomodar">
        

        <asp:Label ID="Label1" runat="server" Text="Ingrese nombre  : " CssClass="separar"></asp:Label>
        <asp:TextBox ID="Txtnombre" runat="server"></asp:TextBox>

        <asp:Label ID="Label2" runat="server" Text="Ingrese apellido : " CssClass="separar"></asp:Label><asp:TextBox ID="Txtapellido" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Ingrese Nombre Usuario :" CssClass="separar"></asp:Label>
        <asp:TextBox ID="TxtnombreUsuario" runat="server"></asp:TextBox>
        <br />


        <asp:Label ID="Label4" runat="server" Text="Ingrese email : " CssClass="separar"></asp:Label>
        <asp:TextBox ID="Txtemail" runat="server" Width="207px"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="Digite clave: " CssClass="separar"></asp:Label>
        <asp:TextBox ID="txtclave" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text=" habilitado" CssClass="separar " />
        <asp:DropDownList ID="Ddlhabilitado" runat="server">
            <asp:ListItem Value="1">Si</asp:ListItem>
            <asp:ListItem Value="0">No</asp:ListItem>
        </asp:DropDownList>
        <br />
        
        <asp:Label ID="Label6" runat="server" CssClass="mover" Text="cambiar clave" />
        <asp:DropDownList ID="Ddlcambiaclave" runat="server">
            <asp:ListItem Value="1">Si</asp:ListItem>
            <asp:ListItem Value="0">No</asp:ListItem>
        </asp:DropDownList>
       
        <br />
        <asp:Label ID="Label9" runat="server" CssClass="mover" Text="Seleccione persona :"> </asp:Label>
        <asp:DropDownList ID="Ddlpersona" runat="server"></asp:DropDownList>
    </div>
    <br />
    <br />

    <asp:GridView ID="GridView1" runat="server" CssClass="gv" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <SelectedRowStyle BorderColor="#FF0066" />
    </asp:GridView>

    <br />

    <div class=" botones">

        <asp:Button ID="btnagregar" runat="server" Text="Agregar " OnClick="btnagregar_Click" CssClass="boton" Height="32px" />
        <asp:Button ID="btneditar" runat="server" Text="Modificar " OnClick="btneditar_Click" Style="height: 35px" CssClass="boton" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar " OnClick="btnEliminar_Click" Height="33px" />


    </div>
    <asp:Label ID="Error" runat="server" CssClass="error" Text="AH ocurrido un error!"></asp:Label>

    

</asp:Content>
