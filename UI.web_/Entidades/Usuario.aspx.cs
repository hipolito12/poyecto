using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;
namespace UI.web_.Entidades
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Error.Visible = false;
            cargarcombos();
            cargargv();
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
                if (txtclave.Text==null||Txtapellido.Text==null
                    ||Txtemail.Text==null||Txtnombre.Text==null||TxtnombreUsuario.Text==null
                    || txtclave.Text == "" || Txtapellido.Text == ""
                    || Txtemail.Text == ""|| Txtnombre.Text == "" || TxtnombreUsuario.Text == "") 
                {
                    Error.Text = "Hay campos vacios!";
                    Error.Visible = true;
                }
                Usuario_ us = new Usuario_();
                int clave = int.Parse(Ddlcambiaclave.SelectedValue);
                int cambia = Convert.ToInt32(Ddlhabilitado.SelectedValue);
               
                us.agregegarUsuarios(us.cargarcombo()[Ddlpersona.SelectedValue].ToString(), Txtnombre.Text,TxtnombreUsuario.Text
                   , Txtapellido.Text,txtclave.Text, Convert.ToBoolean(clave),Convert.ToBoolean(cambia),Txtemail.Text  ) ;
                
                
                cargargv();
            }
            catch (Exception ex )
            {
                Error.Text = ex.ToString();
                Error.Visible = true;

            }
        }

        protected void btneditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtclave.Text == null || Txtapellido.Text == null
                    || Txtemail.Text == null || Txtnombre.Text == null || TxtnombreUsuario.Text == null
                    || txtclave.Text == "" || Txtapellido.Text == ""
                    || Txtemail.Text == "" || Txtnombre.Text == "" || TxtnombreUsuario.Text == "")
                {
                    Error.Text = "Hay campos vacios!";
                    Error.Visible = true;
                }
                Usuario_ us = new Usuario_();
                int clave = int.Parse(Ddlcambiaclave.SelectedValue);
                int cambia = Convert.ToInt32(Ddlhabilitado.SelectedValue);
                string id = GridView1.SelectedRow.Cells[1].Text;
                
                us.editUsuarios(id, us.cargarcombo()[Ddlpersona.SelectedValue].ToString(), Txtnombre.Text, TxtnombreUsuario.Text
                   , Txtapellido.Text, txtclave.Text, Convert.ToBoolean(clave), Convert.ToBoolean(cambia), Txtemail.Text);
               
                
                cargargv();
            }
            catch (Exception ex)
            {
                Error.Text = ex.ToString();
                Error.Visible = true;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtclave.Text == null || Txtapellido.Text == null
                    || Txtemail.Text == null || Txtnombre.Text == null || TxtnombreUsuario.Text == null
                    || txtclave.Text == "" || Txtapellido.Text == ""
                    || Txtemail.Text == "" || Txtnombre.Text == "" || TxtnombreUsuario.Text == "")
                {
                    Error.Text = "Hay campos vacios!";
                    Error.Visible = true;
                }
                Usuario_ us = new Usuario_();
                string id = GridView1.SelectedRow.Cells[1].Text;
                us.eliminarUsuarios(id);
                cargargv();
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