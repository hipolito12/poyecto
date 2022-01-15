   <%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_Maestra.Master" AutoEventWireup="true" CodeBehind="Calificar_alumnos.aspx.cs" Inherits="UI.web_.Reportes.Calificar_alumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="aa" runat="server">
    <center> 
        <asp:Label ID="Label2" runat="server" Text="Seleccione curso" Font-Bold="True"></asp:Label>
        <br />
    <asp:DropDownList ID="DropDownList1" runat="server" Width="313px" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="id_curso" DataValueField="id_curso">
    </asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tp2ConnectionString %>" SelectCommand="SELECT [id_curso] FROM [cursos]"></asp:SqlDataSource>

    <br />

    <br>
        <asp:Label ID="lblCondicion" runat="server" Text="Seleccione Condicion del alumno" Font-Bold="True"></asp:Label>
        <br />
     <asp:DropDownList ID="DropDownList2" runat="server" Width="313px" AutoPostBack="True">
         <asp:ListItem>Aprobacion directa</asp:ListItem>
         <asp:ListItem>Libre</asp:ListItem>
         <asp:ListItem>aprobado</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
        <asp:Label ID="Label3" runat="server" Text="Ingrese Nota del alumno" Font-Bold="True"></asp:Label>
        <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    

        <br />
    

    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" ReadOnly="True" SortExpression="nombre" />
            <asp:BoundField DataField="legajo" HeaderText="legajo" SortExpression="legajo" />
            <asp:BoundField DataField="id_curso" HeaderText="id_curso" SortExpression="id_curso" />
            <asp:BoundField DataField="condicion" HeaderText="condicion" SortExpression="condicion" />
            <asp:BoundField DataField="nota" HeaderText="nota" SortExpression="nota" />
        </Columns>
        <SelectedRowStyle BackColor="#FF99CC" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:tp2ConnectionString %>" SelectCommand="select distinct CONCAT( p.nombre ,' ', p.apellido) as nombre,p.legajo
, ai.id_curso, ai.condicion, ai.nota from alumnos_inscripciones ai
join personas p on p.id_persona = ai.id_alumno
where ai.id_curso = @cur;">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="0" Name="cur" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
        <br />
        <asp:Label ID="lblinformar" runat="server" Text="Label"></asp:Label>
    <br />
</center>  
</asp:Content>
