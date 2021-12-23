using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;

namespace UI.web_.Entidades
{
    public partial class Personas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Error.Visible = false;
            cargarcombo();
            cargargv();
            cargartipo();
        }

        private Dictionary<string,int> cargartipo()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("Profesor",1);
            dic.Add("Alumno", 2);
            dic.Add("Administrador", 0);

            return dic;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           Txtnombre.Text= GridView1.SelectedRow.Cells[2].Text;
            Txtapellido.Text = GridView1.SelectedRow.Cells[3].Text;
            Txtdireccion.Text = GridView1.SelectedRow.Cells[4].Text;
            Txtemail.Text = GridView1.SelectedRow.Cells[5].Text;
            Txttelefono.Text = GridView1.SelectedRow.Cells[6].Text;
            Txtnacimiento.Text = GridView1.SelectedRow.Cells[7].Text;
            Txtlegajo.Text = GridView1.SelectedRow.Cells[8].Text;
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtapellido.Text==null||
                    Txtnombre.Text==null|| Txtemail.Text==null|| Txtlegajo.Text==null||
                    Txtnacimiento.Text==null|| Txttelefono.Text==null||Txtdireccion.Text==null) 
                {
                    Error.Text = "hay campos vacios";
                    Error.Visible = true;
                }
                Persona p = new Persona();

                string tipopersona = ddltipo.SelectedValue;
               var Plan= p.cargar()[Ddlplan.SelectedValue];

                p.addpersonas(
                    Txtnombre.Text,
                    Txtapellido.Text,
                    Txtdireccion.Text
                    ,Txtemail.Text
                    ,Txttelefono.Text,
                    Txtnacimiento.Text,
                    Txtlegajo.Text,
                    tipopersona,
                    Plan.ToString()
                    );
                cargargv();
            }
            catch (Exception ex)
            {
                Persona p = new Persona();
                Error.Text = ex.ToString();
                

                Error.Visible = true;
                
            }
        }

        protected void btneditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Txtapellido.Text == null ||
                    Txtnombre.Text == null || Txtemail.Text == null || Txtlegajo.Text == null ||
                    Txtnacimiento.Text == null || Txttelefono.Text == null || Txtdireccion.Text == null)
                {
                    Error.Text = "hay campos vacios";
                    Error.Visible = true;
                }

                Persona p = new Persona();
                string tipopersona = ddltipo.SelectedValue;
                var Plan = p.cargar()[Ddlplan.SelectedValue];
                var id= GridView1.SelectedRow.Cells[1].Text;
                p.modifypersonas(id,Txtnombre.Text, Txtapellido.Text, Txtdireccion.Text, Txtemail.Text
                    , Txttelefono.Text, Txtnacimiento.Text, Txtlegajo.Text, tipopersona, Plan.ToString());
                cargargv();
            }
            catch (Exception ex )
            {
                Error.Text =  ex.ToString();

                Error.Visible = true;

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Txtapellido.Text == null ||
                    Txtnombre.Text == null || Txtemail.Text == null || Txtlegajo.Text == null ||
                    Txtnacimiento.Text == null || Txttelefono.Text == null || Txtdireccion.Text == null)
                {
                    Error.Text = "hay campos vacios";
                    Error.Visible = true;
                }
                Persona p = new Persona();
                var id = GridView1.SelectedRow.Cells[1].Text;
                p.deletepersonas(id);
                cargargv();
            }
            catch (Exception)
            {

                Error.Text = "ah ocurrido un error";
                Error.Visible = true;
            }
        }

        void cargargv() 
        {
            Persona p = new Persona();
            GridView1.DataSource = p.cargargv();
            GridView1.DataBind();
        }
        void cargarcombo() 
        {
            Persona p = new Persona();
            foreach (var k in p.cargar().Keys) 
            {
                Ddlplan.Items.Add(k);
            }
        }
    }
}