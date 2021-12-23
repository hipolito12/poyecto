using System;
using System.Collections.Generic;
using System.Linq;
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
            cargarcombos();
            cargargv();
            error.Visible = false;
        }

        protected void btnagregar_Click1(object sender, EventArgs e)
        {

            try
            {
                if (Txtalumno.Text == null || Txtnota.Text == null || Txtalumno.Text == "" || Txtnota.Text == "")
                {
                    error.Text = "hay campos vacios";
                    error.Visible = true;
                }
                _Inscripciones_Alumnos ai = new _Inscripciones_Alumnos();
                ai.agregar(ai.cargacombos().Item1[ddlalumno.SelectedValue].ToString(),
                    ai.cargacombos().Item2[ddlcurso.SelectedValue].ToString(), Txtalumno.Text, Txtnota.Text);
                cargargv();
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
                if (Txtalumno.Text == null || Txtnota.Text == null || Txtalumno.Text == "" || Txtnota.Text == "")
                {
                    error.Text = "hay campos vacios";
                    error.Visible = true;
                }
                _Inscripciones_Alumnos ai = new _Inscripciones_Alumnos();
                var id = GridView1.SelectedRow.Cells[1].Text;
                ai.modificar(ai.cargacombos().Item1[ddlalumno.SelectedValue].ToString(),
                    ai.cargacombos().Item2[ddlcurso.SelectedValue].ToString(), Txtalumno.Text, Txtnota.Text, id);
                cargargv();
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

            foreach (var k in ai.cargacombos().Item2.Keys)
            {
                ddlcurso.Items.Add(k);
            }
        }

        protected void Btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtalumno.Text == null || Txtnota.Text == null || Txtalumno.Text == "" || Txtnota.Text == "")
                {
                    error.Text = "hay campos vacios";
                    error.Visible = true;
                }
                _Inscripciones_Alumnos ai = new _Inscripciones_Alumnos();
                var id = GridView1.SelectedRow.Cells[1].Text;
                ai.eliminar(id);
                cargargv();
            }
            catch (Exception)
            {

                error.Visible = true;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Txtalumno.Text = GridView1.SelectedRow.Cells[4].Text;
            Txtnota.Text = GridView1.SelectedRow.Cells[5].Text;
        }
    }
}