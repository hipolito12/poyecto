using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using CapaNegocios;
using System.Web.UI.WebControls;

namespace UI.web_.Entidades.Estilos
{
    public partial class Materias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            error.Visible = false;
            cargagv();
            cargarcombos();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           Txtdescripcion.Text = GridView1.SelectedRow.Cells[2].Text;
            Txtsemanales.Text = GridView1.SelectedRow.Cells[3].Text;
            Txttotales.Text = GridView1.SelectedRow.Cells[4].Text;
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtdescripcion.Text == null || Txtsemanales.Text == null || Txttotales.Text == null ||
                        Txtdescripcion.Text == "" || Txtsemanales.Text == "" || Txttotales.Text == "")
                {
                    error.Text = "hay campos vacios!";
                    error.Visible = true;
                }
                Materia_n mat = new Materia_n();

                mat.agregarmateria(Txtdescripcion.Text, Txtsemanales.Text, Txttotales.Text, mat.busqueda(ddlplan.SelectedValue).ToString());
                cargagv();
            }
            catch (Exception)
            {

                
                error.Visible = true;
            }
        }

        protected void Btneditar_Click(object sender, EventArgs e)
        {
            Materia_n mat = new Materia_n();
            var id = GridView1.SelectedRow.Cells[1].Text;
            
            mat.EditarMaterias(Txtdescripcion.Text, id,Txtsemanales.Text, Txttotales.Text,mat.busqueda(ddlplan.SelectedValue).ToString());
            cargagv();
        }

        void cargarcombos() 
        {
            Materia_n mat = new Materia_n();
            foreach (var k in  mat.carga()) 
            {
                ddlplan.Items.Add(k);
            }
        }

        void  cargagv() 
        {
            Materia_n mat = new Materia_n();
            GridView1.DataSource = mat.cargagv();
            GridView1.DataBind();
        }

        protected void Btneliminar_Click(object sender, EventArgs e)
        {
            var id = GridView1.SelectedRow.Cells[1].Text;
            Materia_n mat = new Materia_n();
            mat.eliminarMateria(id);
        }
    }
}