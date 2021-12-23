using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;

namespace UI.web_.Entidades
{
    public partial class docentes_curso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            error.Visible = false;
            cargarcombos();
            cargagv();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtcargo.Text= gv.SelectedRow.Cells[4].Text;
        }

        protected void btncarga_Click(object sender, EventArgs e)
        {
            if (Txtcargo.Text == null || Txtcargo.Text == "")
            {
                error.Text = "Hay campos vacios!";
                error.Visible = true;

            }
            docentes_cursos_CRUD dc = new docentes_cursos_CRUD();
            var curso = dc.cargaDeCombos().Item2[ddlcurso.SelectedValue];
            var docente = dc.cargaDeCombos().Item1[ddldocente.SelectedValue];
          
            dc.ADDdocenteCURSO(Txtcargo.Text,curso.ToString(), docente.ToString());
            cargagv();
        }
        protected void btnmodificacion_Click(object sender, EventArgs e)
        {
            if (Txtcargo.Text == null || Txtcargo.Text == "")
            {
                error.Text = "Hay campos vacios!";
                error.Visible = true;

            }

            docentes_cursos_CRUD dc = new docentes_cursos_CRUD();
            var curso = dc.cargaDeCombos().Item2[ddlcurso.SelectedValue];
            var docente = dc.cargaDeCombos().Item1[ddldocente.SelectedValue];
            string id =  gv.SelectedRow.Cells[1].Text;
            dc.EDITdoceneteCURSO(Txtcargo.Text, curso.ToString(), docente.ToString() ,id);

            cargagv();
        }

        protected void Btneliminar_Click(object sender, EventArgs e)
        {
            if (Txtcargo.Text == null || Txtcargo.Text == "")
            {
                error.Text = "Hay campos vacios!";
                error.Visible = true;

            }

            string id = Txtcargo.Text = gv.SelectedRow.Cells[1].Text;
            docentes_cursos_CRUD dc = new docentes_cursos_CRUD();
            var curso = dc.cargaDeCombos().Item2[ddlcurso.SelectedValue];
            var docente = dc.cargaDeCombos().Item1[ddldocente.SelectedValue];
            dc.DELETEdocentesCURSO( curso.ToString(), docente.ToString() );
            cargagv();
        }

        void cargagv() 
        {
            docentes_cursos_CRUD dc = new docentes_cursos_CRUD();
            gv.DataSource = dc.cargagv();
            gv.DataBind();
        }    
    
    
       void cargarcombos() 
        {
            docentes_cursos_CRUD dc = new docentes_cursos_CRUD();
            foreach (var k in dc.cargaDeCombos().Item1.Keys) 
            {
                ddldocente.Items.Add(k);
            }

            foreach (var k in dc.cargaDeCombos().Item2.Keys)
            {
                ddlcurso.Items.Add(k);
              
            }
        }

       
    }
}