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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            error.Visible = false;
            if (!IsPostBack) 
            { 
                cargarCombos();
                cargarGv();

            }
           
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtplan.Text != "" && true == Regex.IsMatch(Txtplan.Text, "[A-Z,a-z,0-9]{10,200}"))
                {
                   Plan_ pla = new Plan_();

                  string especialidad = pla.cargargarcombos()[Ddlespecialidad.SelectedValue].ToString();
                   pla.agregarplan(Txtplan.Text,especialidad);
                   cargarGv();
                    error.Text = "agregado!";
                    error.Visible = true;
                }
                else { error.Text = "hay campos vacios";
                    error.Visible = true; }
                

            }
            catch (Exception)
            {

                error.Visible = true;
            }
        }

        void cargarCombos() 
        {
            Plan_ pla = new Plan_();
           foreach(var k in pla.cargargarcombos().Keys) 
            {
                Ddlespecialidad.Items.Add(k);
            }
        }


        void cargarGv()
        {Plan_ pla = new Plan_();
            gv.DataSource = pla.cargargv();
            gv.DataBind();
        }

        protected void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtplan.Text != "" && true == Regex.IsMatch(Txtplan.Text, "[A-Z,a-z,0-9]{10,200}"))
                {
                     Plan_ pla = new Plan_();
                     var id = gv.SelectedRow.Cells[1].Text; 
                     pla.editplan(id,Txtplan.Text, pla.cargargarcombos()[Ddlespecialidad.SelectedValue].ToString());
                     cargarGv();
                    error.Text = "Modificado!";
                    error.Visible = true;
                }
                else 
                {
                    
                    error.Text = "hay campos vacios";
                    error.Visible = true;

                }
               

            }
            catch (Exception)
            {

                error.Visible = true;
            }
        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
               Txtplan.Text = gv.SelectedRow.Cells[2].Text;
            }
            else {  }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtplan.Text != "" && true == Regex.IsMatch(Txtplan.Text, "[A-Z,a-z,0-9]{10,200}"))
                {
                     Plan_ pla = new Plan_();
                   var id = gv.SelectedRow.Cells[1].Text; 
                   pla.eliminaplan(id);
                    cargarGv();
                    error.Text = "Eliminar";
                    error.Visible = true;
                }
                else 
                {
                    error.Text = "hay campos vacios";
                    error.Visible = true;

                }
               

            }
            catch (Exception)
            {

                error.Visible = true;
            }
        }
    }
}