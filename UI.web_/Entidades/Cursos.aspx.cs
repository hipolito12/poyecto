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
    public partial class Cursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            { 
                cargargridview();
               cargarcombos();
              
            } error.Visible = false;
        
        }

        protected void comboidmateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        
        
        void  cargarcombos() 
        {
            CursosCRUD c = new CursosCRUD();
            foreach (var k in c.devuelv_combo().Item1.Keys) 
            
            {
                comboidmateria.Items.Add(k);
            }
            foreach (var k1 in c.devuelv_combo().Item2.Keys)

            {
                comboComision.Items.Add(k1);
            }
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                int cupo = Convert.ToInt32(txtcupo.Text);
                if ( cupo <= 100 && cupo >0 && Regex.IsMatch(txtcupo.Text ,"[0-9]")==true 
                    && true==Regex.IsMatch(TxtAnio.Text, "[0-9]"))
                {

                    CursosCRUD c = new CursosCRUD();
                    var materia = c.devuelv_combo().Item1[comboidmateria.SelectedItem.ToString()];
                    var comsion = c.devuelv_combo().Item2[comboComision.SelectedItem.ToString()];

                   
                   
                    c.agregarCurso(materia.ToString(), comsion.ToString(), txtcupo.Text, TxtAnio.Text);
                    cargargridview();
                    error.Text = "agregado"; error.Visible = true;
                }
                else 
                { 
                    error.Text = $"hay campos vacios!, verifique la entrada y " +
                        $"\n" +
                        $"  los cupos tienen que ser menor a 100";
                    error.Visible = true;

                }

               
            }
            catch (Exception ex)
            {
                error.Text =" Ah ocurrido un error intente nuevamente" ; 
                error.Visible = true; 
            }
        }

        protected void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                int cupo = Convert.ToInt32(txtcupo.Text);

                if (cupo <= 100 && cupo > 0 && TxtAnio.Text != "" && Regex.IsMatch(txtcupo.Text, "[0-9]") == true
                    && true == Regex.IsMatch(TxtAnio.Text, "[0-9]"))
                {
                     CursosCRUD c = new CursosCRUD();
                   var materia = c.devuelv_combo().Item1[comboidmateria.SelectedValue];
                   var comsion = c.devuelv_combo().Item2[comboComision.SelectedValue];
                   string id = GridView1.SelectedRow.Cells[1].Text;
                   c.EditarCurso(id, comsion.ToString(), txtcupo.Text, TxtAnio.Text, materia.ToString());
                    cargargridview();
                    error.Text = "Modificado!"; error.Visible = true;
                }
                else 
                {
                    error.Text = $"hay campos vacios!, verifique la entrada y " +
                        $"\n" +
                        $"  los cupos tienen que ser menor a 100";
                    error.Visible = true;

                }
               
            }
            catch (Exception ex ) {
                error.Text = " Ah ocurrido un error intente nuevamente"; ;
                error.Visible = true;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtcupo.Text) < 100 && Convert.ToInt32(txtcupo.Text) > 0 && TxtAnio.Text != ""
                     && Regex.IsMatch(txtcupo.Text, "[0-9]") == true && true == Regex.IsMatch(TxtAnio.Text, "[0-9]") )
                  {CursosCRUD c = new CursosCRUD();
                   var id = GridView1.SelectedRow.Cells[1].Text;
              
                   c.elimminarcurso(id);
                     cargargridview();
                    error.Text = "Eliminado!"; error.Visible = true;
                }
                else 
                {error.Text = $"hay campos vacios!, verifique la entrada y el formato de los campos";
                    error.Visible = true;


                }
                
            }
            catch(Exception exe) {
                error.Text = $"Ha ocurrido un error , intentelo nuevamente!";
                error.Visible = true;
            }
        }
    
    
       void cargargridview()
        {
            CursosCRUD c = new CursosCRUD();
            GridView1.DataSource= c.cargargridview();
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcupo.Text = GridView1.SelectedRow.Cells[5].Text;
            TxtAnio.Text = GridView1.SelectedRow.Cells[4].Text;
        }
    }
}