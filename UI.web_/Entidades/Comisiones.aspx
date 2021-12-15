<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.web_.Entidades.Comisiones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Estilos/Comisiones.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <div id="formulario">
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
            <asp:TextBox ID="txt_IdPlan" runat="server" OnTextChanged="TextBox1_TextChanged" CssClass="mover "> </asp:TextBox>

            <div id="gridView">
                <br />
                <asp:GridView ID="GridView1" runat="server" Height="285px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="446px" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </div>
            <br />
            <div id="Botones">

                <asp:Button ID="btnagregar" runat="server" Text="Agregar" CssClass="btnagrega" />
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btnmodificar" OnClick="btnModificar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />

            </div>
    </div>
    </form>
</body>
</html>
