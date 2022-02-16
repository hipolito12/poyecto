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
    public partial class Especialidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            { 
                error.Visible = false;
               cargarGridview();
            }
        }

        protected void especialidadgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtdescripcion.Text = especialidadgv.SelectedRow.Cells[2].Text;
        }

        protected void txtAlta_Click(object sender, EventArgs e)
        {
            try 
            {
                if (Txtdescripcion.Text != "" && true == Regex.IsMatch(Txtdescripcion.Text, "[A-Z,a-z,0-9]"))
                {
                    Especialidad esp = new Especialidad();
                    esp.addEspecialidad(Txtdescripcion.Text);
                    cargarGridview();
                }
                else 
                {
                    error.Text = "Hay campos vacios! o no cumplen el formato"; error.Visible = true; 

                }
                
            }
            catch (Exception ex) { error.Text = " Ah ocurrido un error intente nuevamente"; ; error.Visible = true;  }
        }

        protected void txtmodificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtdescripcion.Text != "" && true == Regex.IsMatch(Txtdescripcion.Text, "[A-Z,a-z,0-9]"))
                {
                    Especialidad esp = new Especialidad();
                    string id = especialidadgv.SelectedRow.Cells[1].Text;
                    esp.Editespecialidades(id, Txtdescripcion.Text);
                    cargarGridview();
                }
                else 
                {
                    error.Text = "Hay campos vacios! o no cumplen el formato"; error.Visible = true;
                }
               
            }
            catch (Exception ex) { error.Text = " Ah ocurrido un error intente nuevamente"; error.Visible = true; }
        }

        protected void txteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtdescripcion.Text != "" && true == Regex.IsMatch(Txtdescripcion.Text, "[A-Z,a-z,0-9]"))
                {
                    Especialidad esp = new Especialidad();
                    string id = especialidadgv.SelectedRow.Cells[1].Text;
                    esp.delete_especialidad(id);
                    cargarGridview();
                }
                else
                {
                    error.Text = "Hay campos vacios! o no cumplen el formato"; error.Visible = true;
                }
               

            }
            catch (Exception ex) { error.Text = " Ah ocurrido un error intente nuevamente"; error.Visible = true; }
        }
    
    
    
        void cargarGridview() 
        {
            Especialidad esp = new Especialidad();
            especialidadgv.DataSource = esp.cargagv();
            especialidadgv.DataBind();
        }
    
    }
}