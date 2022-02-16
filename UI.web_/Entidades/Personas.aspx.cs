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
    public partial class Personas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Error.Visible = false;
                cargarcombo();
                cargargv();
                cargartipo();
            }
        }

        private Dictionary<string, int> cargartipo()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("Profesor", 1);
            dic.Add("Alumno", 2);
            dic.Add("Administrador", 0);

            return dic;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtnombre.Text = GridView1.SelectedRow.Cells[2].Text;
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
                if (
                    Txtapellido.Text != "" &&
                    Txtnombre.Text != "" && Txtemail.Text != "" && Txtlegajo.Text != "" &&
                    Txtnacimiento.Text != "" && Txttelefono.Text != "" && Txtdireccion.Text != ""
                    &&
                     Regex.IsMatch(Txtemail.Text, "[a-z,A-Z,0-9]@[a-z]{10,30}") != false
                    && Regex.IsMatch(Txtlegajo.Text, "[0-9]{5-12}") != false
                    && Regex.IsMatch(Txtnacimiento.Text, "[0-9]/[0-9]/[0-9]") != false
                    && Regex.IsMatch(Txttelefono.Text, "[0-9]{1,10}") != false
                    && Regex.IsMatch(Txtapellido.Text, "[A-z,a-z]{5,50}") != false
                    && Regex.IsMatch(Txtnombre.Text, "[A-z,a-z]{5,50}") != false)
                {
                    Persona p = new Persona();

                    string tipopersona = ddltipo.SelectedValue;
                    var Plan = p.cargar()[Ddlplan.SelectedItem.Text];
                   
                    p.addpersonas(

                        Txtnombre.Text,
                        Txtapellido.Text,
                        Txtdireccion.Text
                        , Txtemail.Text
                        , Txttelefono.Text,
                        Txtnacimiento.Text,
                        Txtlegajo.Text,
                        tipopersona,
                        Plan.ToString()
                        );
                    cargargv();

                    Error.Text = "Agregado";
                    Error.Visible = true;

                }
                else 
                {
                    Error.Text = "hay campos vacios o no cumplen el formato necesario";
                    Error.Visible = true;

                }
                
            }
            catch (Exception ex)
            {
                Persona p = new Persona();
                Error.Text = " Ah ocurrido un error intente nuevamente" + ex.Message;


                Error.Visible = true;

            }
        }

        protected void btneditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Txtapellido.Text != "" &&
                    Txtnombre.Text != "" && Txtemail.Text != "" && Txtlegajo.Text != "" &&
                    Txtnacimiento.Text != "" && Txttelefono.Text != "" && Txtdireccion.Text != ""
                    &&
                     Regex.IsMatch(Txtemail.Text, "[a-z,A-Z,0-9]@[a-z]{10,30}") != false
                    && Regex.IsMatch(Txtlegajo.Text, "[0-9]{5-12}") != false
                    && Regex.IsMatch(Txtnacimiento.Text, "[0-9]/[0-9]/[0-9]") != false
                    && Regex.IsMatch(Txttelefono.Text, "[0-9]{1,10}") != false
                    && Regex.IsMatch(Txtapellido.Text, "[A-z,a-z]{5,50}") != false
                    && Regex.IsMatch(Txtnombre.Text, "[A-z,a-z]{5,50}") != false)
                {
                    Persona p = new Persona();
                    string tipopersona = ddltipo.SelectedValue;
                    var Plan = p.cargar()[Ddlplan.SelectedItem.Text];
                    var id = GridView1.SelectedRow.Cells[1].Text;
                    p.modifypersonas(id, Txtnombre.Text, Txtapellido.Text, Txtdireccion.Text, Txtemail.Text
                        , Txttelefono.Text, Txtnacimiento.Text, Txtlegajo.Text, tipopersona, Plan.ToString());

                    cargargv();
                    Error.Text = "modificado";
                    Error.Visible = true;
                }
                else 
                
                { Error.Text = "hay campos vacios o no cumplen con el formato necesario";
                    Error.Visible = true;

                }

               
            }
            catch (Exception ex)
            {
                Error.Text = " Ah ocurrido un error intente nuevamente";

                Error.Visible = true;

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Txtapellido.Text != "" &&
                    Txtnombre.Text != "" && Txtemail.Text != "" && Txtlegajo.Text != "" &&
                    Txtnacimiento.Text != "" && Txttelefono.Text != "" && Txtdireccion.Text != ""
                    &&
                     Regex.IsMatch(Txtemail.Text, "[a-z,A-Z,0-9]@[a-z]{10,30}") != false
                    && Regex.IsMatch(Txtlegajo.Text, "[0-9]{5-12}") != false
                    && Regex.IsMatch(Txtnacimiento.Text, "[0-9]/[0-9]/[0-9]") != false
                    && Regex.IsMatch(Txttelefono.Text, "[0-9]{1,10}") != false
                    && Regex.IsMatch(Txtapellido.Text, "[A-z,a-z]{5,50}") != false
                    && Regex.IsMatch(Txtnombre.Text, "[A-z,a-z]{5,50}") != false)
                {
                   Persona p = new Persona();
                   var id = GridView1.SelectedRow.Cells[1].Text;
                   p.deletepersonas(id);
                       cargargv();
                    Error.Text = "Eliminada";
                    Error.Visible = true;
                }
                else 
                { 
                    Error.Text = "hay campos vacios o no cumplen con el formato necesario";
                    Error.Visible = true;

                }
                
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

        protected void Txtnacimiento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}