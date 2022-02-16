using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;
namespace UI.web_.Entidades
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {  if (!IsPostBack)
            {
                Error.Visible = false;
                cargarcombos();
                cargargv();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtclave.Text = GridView1.SelectedRow.Cells[3].Text;
            TxtnombreUsuario.Text = GridView1.SelectedRow.Cells[2].Text;
            Txtnombre.Text = GridView1.SelectedRow.Cells[5].Text;
            Txtapellido.Text = GridView1.SelectedRow.Cells[6].Text;
            Txtemail.Text = GridView1.SelectedRow.Cells[7].Text;

        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                     txtclave.Text != "" && Txtapellido.Text != ""
                    && Txtemail.Text != "" && Txtnombre.Text != "" && TxtnombreUsuario.Text != ""
                    && Regex.IsMatch(Txtapellido.Text, "[A-z,a-z]{4,20}") == true
                    && Regex.IsMatch(Txtnombre.Text, "[A-z,a-z]{4,20}") == true
                    && Regex.IsMatch(Txtemail.Text, "[A-z,a-z,0-9]@[a-z]") == true
                    && Regex.IsMatch(TxtnombreUsuario.Text, "[A-z,a-z]{4,20}") == true
                    && Regex.IsMatch(txtclave.Text, "[A-z,a-z,0-9]{8,20}") == true
                    )
                {
                    Usuario_ us = new Usuario_();
                 int clave = int.Parse(Ddlcambiaclave.SelectedValue);
                 int cambia = Convert.ToInt32(Ddlhabilitado.SelectedValue);
               
                  us.agregegarUsuarios(us.cargarcombo()[Ddlpersona.SelectedValue].ToString(), Txtnombre.Text,TxtnombreUsuario.Text
                   , Txtapellido.Text,txtclave.Text, Convert.ToBoolean(clave),Convert.ToBoolean(cambia),Txtemail.Text  ) ;
                
                
                  cargargv();
                  Error.Text = "se ha agregado un nuevo usuario!";
                  Error.Visible = true;
                }
                else {  Error.Text = "Hay campos vacios o no cumplen con la condicio!";
                    Error.Visible = true;}
               
            }
            catch (Exception ex )
            {
                Error.Text = " Ah ocurrido un error intente nuevamente"; 
                Error.Visible = true;

            }
        }

        protected void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                          txtclave.Text != "" && Txtapellido.Text != ""
                    && Txtemail.Text != "" && Txtnombre.Text != "" && TxtnombreUsuario.Text != ""
                    && Regex.IsMatch(Txtapellido.Text, "[A-z,a-z]{4,20}") == true
                    && Regex.IsMatch(Txtnombre.Text, "[A-z,a-z]{4,20}") == true
                    && Regex.IsMatch(Txtemail.Text, "[A-z,a-z,0-9]@[a-z]") == true
                    && Regex.IsMatch(TxtnombreUsuario.Text, "[A-z,a-z]{4,20}") == true
                    && Regex.IsMatch(txtclave.Text, "[A-z,a-z,0-9]{8,20}") == true
                                    )
                {
                    Usuario_ us = new Usuario_();
                int clave = int.Parse(Ddlcambiaclave.SelectedValue);
                int cambia = Convert.ToInt32(Ddlhabilitado.SelectedValue);
                string id = GridView1.SelectedRow.Cells[1].Text;
                
                us.editUsuarios(id, us.cargarcombo()[Ddlpersona.SelectedValue].ToString(), Txtnombre.Text, TxtnombreUsuario.Text
                   , Txtapellido.Text, txtclave.Text, Convert.ToBoolean(clave), Convert.ToBoolean(cambia), Txtemail.Text);
               
                
                cargargv();

                Error.Text = "se ha Modificado!";
                Error.Visible = true;

                }
                else 
                { 
                    Error.Text = "Hay campos vacios o no cumplen el formtai necesario! ";
                    Error.Visible = true;

                }
               
            }
            catch (Exception ex)
            {
                Error.Text = " Ah ocurrido un error intente nuevamente"; 
                Error.Visible = true;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (
                     txtclave.Text != "" 
                     && Txtapellido.Text != ""
                    && Txtemail.Text != "" && Txtnombre.Text != "" && TxtnombreUsuario.Text != ""
                    && Regex.IsMatch(Txtapellido.Text, "[A-z,a-z]{4,20}") == true
                    && Regex.IsMatch(Txtnombre.Text, "[A-z,a-z]{4,20}") == true
                    && Regex.IsMatch(Txtemail.Text, "[A-z,a-z,0-9]@[a-z]") == true
                    && Regex.IsMatch(TxtnombreUsuario.Text, "[A-z,a-z]{4,20}") == true
                    && Regex.IsMatch(txtclave.Text, "[A-z,a-z,0-9]{4,20}") == true
                    )
                {
                    Usuario_ us = new Usuario_();
                string id = GridView1.SelectedRow.Cells[1].Text;
                us.eliminarUsuarios(id);
                cargargv();
                Error.Text = "se ha eliminado!";
                Error.Visible = true;
                }
                else {Error.Text = "Hay campos vacios!";
                    Error.Visible = true; }
                
            }
            catch (Exception)
            {
                Error.Visible = true;

            }
        }

        void cargargv() 
        {
            // hacer cargar a gv
            Usuario_ us = new Usuario_();
            GridView1.DataSource = us.cargargv();
            GridView1.DataBind();
        }

        void cargarcombos() 
        {
            Usuario_ us = new Usuario_();
            foreach (var k in us.cargarcombo().Keys) {//hacer cargacombo de personas
                Ddlpersona.Items.Add(k); 
            }

        }
    }
}