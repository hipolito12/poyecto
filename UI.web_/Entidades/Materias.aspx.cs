using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using CapaNegocios;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace UI.web_.Entidades.Estilos
{
    public partial class Materias : System.Web.UI.Page
    {
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            { 
              error.Visible = false;
              cargagv();
              cargarcombos();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           Txtdescripcion.Text = GridView1.SelectedRow.Cells[2].Text;
            Txtsemanales.Text = GridView1.SelectedRow.Cells[3].Text;
            Txttotales.Text = GridView1.SelectedRow.Cells[4].Text;
             id = GridView1.SelectedRow.Cells[1].Text;
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                          Txtdescripcion.Text != "" && Txtsemanales.Text != "" && Txttotales.Text != ""
                        && true == Regex.IsMatch(Txtdescripcion.Text, "[A-Z,a-z]")
                        && true == Regex.IsMatch(Txtsemanales.Text, "[0-9]")
                        && true == Regex.IsMatch(Txttotales.Text, "[0-9]")
                    )
                {
                    Materia_n mat = new Materia_n();

                   mat.agregarmateria(Txtdescripcion.Text, Txtsemanales.Text, Txttotales.Text, mat.busqueda(ddlplan.SelectedValue).ToString());
                   
                    cargagv();
                }
                else 
                {
                    error.Text = "hay campos vacios!";
                    error.Visible = true;

                }
                
            }
            catch (Exception)
            {

                
                error.Visible = true;
            }
        }

        protected void Btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                                 Txtdescripcion.Text != "" && Txtsemanales.Text != "" && Txttotales.Text != ""
                                && true == Regex.IsMatch(Txtdescripcion.Text, "[A-Z,a-z]")
                                && true == Regex.IsMatch(Txtsemanales.Text, "[0-9]")
                                && true == Regex.IsMatch(Txttotales.Text, "[0-9]")
                                )
                {
                    Materia_n mat = new Materia_n();
                    
                    id = GridView1.SelectedRow.Cells[1].Text;


                    mat.EditarMaterias(Txtdescripcion.Text, id, Txtsemanales.Text, Txttotales.Text, mat.busqueda(ddlplan.SelectedValue).ToString());
                    cargagv();

                }
                else { error.Text = "hay campos vacios o no cumplen el formato"; error.Visible = true; }

            }
            catch (Exception ex)
            {

                error.Text = ex.Message;
                error.Visible = true;
            }
               
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

            if (
                        Txtdescripcion.Text != "" && Txtsemanales.Text != "" && Txttotales.Text != ""
                        && true == Regex.IsMatch(Txtdescripcion.Text, "[A-Z,a-z]")
                        && true == Regex.IsMatch(Txtsemanales.Text, "[0-9]")
                        && true == Regex.IsMatch(Txttotales.Text, "[0-9]")
               )
            {
                var id = GridView1.SelectedRow.Cells[1].Text;
                Materia_n mat = new Materia_n();
                mat.eliminarMateria(id);
                cargagv();

            }

            else 
            {
                error.Text = "hay campos vacios o no cumplen el formato"; error.Visible = true;
            }

                
        }
    }
}