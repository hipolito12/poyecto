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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // cargarcombos();
                cargargv();
                error.Visible = false;
                Txtnota.Enabled = false;
                ddlestado.Enabled = false;
            }
            else
            {
                Txtnota.Enabled = false;
                ddlestado.Enabled = false;
            }
        }

        protected void btnagregar_Click1(object sender, EventArgs e)
        {

            try
            {
                
                             
                
                    _Inscripciones_Alumnos ai = new _Inscripciones_Alumnos();
                    ai.agregar(ddlalumno.SelectedValue.ToString(),
                       ddlcurso.SelectedValue.ToString(), " ", "-1");
                       cargargv();
                    error.Text = "agregado"; error.Visible = true;
                
                
                
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
                if (Txtnota.Text != "" && Regex.IsMatch(Txtnota.Text, "[0-9]{1,2}") == true)
                {
                    _Inscripciones_Alumnos ai = new _Inscripciones_Alumnos();
                    var id = GridView1.SelectedRow.Cells[1].Text;
                    ai.modificar(ddlalumno.SelectedValue,
                      ddlcurso.SelectedValue, ddlestado.SelectedValue, Txtnota.Text, id);
                    cargargv();
                    error.Text = "Modificado!"; error.Visible = true;
                }
                else
                {
                    error.Text = "hay campos vacios o no cumplen el formato necesario (nota entre 0 y 10)";
                    error.Visible = true;

                }
                
            }
            catch (Exception)
            {

                error.Visible = true;
            }
        }

        void cargargv()
        {
            _Inscripciones_Alumnos ai = new _Inscripciones_Alumnos();
            GridView1.DataSource = ai.cargargv();
            GridView1.DataBind();
        }

        void cargarcombos()
        {
            _Inscripciones_Alumnos ai = new _Inscripciones_Alumnos();
            foreach (var k in ai.cargacombos().Item1.Keys)
            {
                ddlalumno.Items.Add(k);
            }


        }

        protected void Btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtnota.Text != "" && Regex.IsMatch(Txtnota.Text, "[0-9]{1,2}") == true)
                {
                    _Inscripciones_Alumnos ai = new _Inscripciones_Alumnos();
                   var id = GridView1.SelectedRow.Cells[1].Text;
                   ai.eliminar(id);
                   cargargv();
                    error.Text = "Eliminado"; error.Visible = true;
                }
                else 
                {
                    error.Text = "hay campos vacios o no cumplen el formato necesario (nota entre 0 y 10)";
                    error.Visible = true;

                }
                
            }
            catch (Exception)
            {

                error.Visible = true;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            Txtnota.Text = GridView1.SelectedRow.Cells[5].Text;
            Txtnota.Enabled = true;
            ddlestado.Enabled = true;
        }
    }
}