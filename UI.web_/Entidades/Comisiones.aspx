<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.web_.Entidades.Comisiones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Estilos/Comisiones.css" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.googleapis.com">
     <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Dosis&display=swap" rel="stylesheet"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
     <link  rel="stylesheet"  href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"/>

    <title>Comisiones Crud
    </title>
</head>
<body>


    <div id="formulario">
        <h1 id="titulo">Comisiones <b>CRUD</b></h1>
        <form id="form" runat="server">


            <asp:Label ID="lblAgregar" runat="server" Text="Ingrese Descripcion: "></asp:Label>
            <asp:TextBox ID="txtDesc_Comision" runat="server" OnTextChanged="TextBox1_TextChanged" CssClass="mover"> </asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblModificar" runat="server" Text="Ingrese Año de comision: "></asp:Label>
            <asp:TextBox ID="txtAnio" runat="server" OnTextChanged="TextBox1_TextChanged" CssClass="moveranio"> </asp:TextBox>
            <br />

            <br />
            <asp:Label ID="lblEliminar" runat="server" Text="Ingrese ID del plan: ">   </asp:Label>
            <asp:DropDownList ID="ddlplan" runat="server" DataSourceID="SqlDataSource1" DataTextField="descripcion del plan " DataValueField="id_plan" Width="221px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:thetrueconextion %>" SelectCommand="use tp2
select p.desc_plan as'descripcion del plan ',p.id_plan from planes p"></asp:SqlDataSource>

            <div id="gridView">
                <br />
                <asp:GridView ID="GridView1" runat="server" Height="285px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="446px" AutoGenerateSelectButton="True" CssClass="gridStyles">
                  
                 </asp:GridView>
            </div>
            <br />
                <asp:Label ID="error" runat="server" Text=" Hay campos vacios o no cumplen el formato , verifique su entrada" CssClass="animate__bounceInRight" />
            <div id="Botones">
                <asp:Button ID="btnagregar" runat="server" Text="Agregar" CssClass="btnagrega" OnClick="btnagregar_Click" />
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btnmodificar" OnClick="btnModificar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />

            </div>
    </div>
    </form>
</body>
</html>
