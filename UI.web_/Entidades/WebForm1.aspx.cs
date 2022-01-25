using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;

namespace UI.web_.Entidades
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                error.Visible = false;
                cargargv();
            }
        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdescripcion.Text = gv.SelectedRow.Cells[2].Text;
            txtejecuta.Text= gv.SelectedRow.Cells[3].Text;
        }

        protected void btnalta_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtejecuta.Text == null || txtejecuta.Text == "" || txtdescripcion.Text == null || txtdescripcion.Text == "")
                {
                    error.Text = "ah ocurrido un error!";
                    error.Visible = true;
                }
                ModulosCRUD m = new ModulosCRUD();
                m.ADDmodulo(txtdescripcion.Text, txtejecuta.Text);
                cargargv();
            }
            catch (Exception ex)
            {

                error.Visible = true;
            }
        }

        protected void btnModficaion_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtejecuta.Text == null || txtejecuta.Text == "" || txtdescripcion.Text == null || txtdescripcion.Text == "")
                {
                    error.Text = "ah ocurrido un error!";
                    error.Visible = true;
                }
                ModulosCRUD m = new ModulosCRUD();
               var id=  gv.SelectedRow.Cells[1].Text;
                m.Updatemodulo(txtdescripcion.Text,id ,txtejecuta.Text);
                cargargv();
            }
            catch (Exception ex)
            {

                error.Visible = true;
            }
        }

        protected void Btneliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtejecuta.Text == null || txtejecuta.Text == "" || txtdescripcion.Text == null || txtdescripcion.Text == "")
                {
                    error.Text = "ah ocurrido un error!";
                    error.Visible = true;
                }
                ModulosCRUD m = new ModulosCRUD();
                var id = gv.SelectedRow.Cells[1].Text;
                m.Deletemodulo(id);
                cargargv();
            }
            catch (Exception ex)
            {

                error.Visible = true;
            }

           
        }
        public void cargargv()
        {
            ModulosCRUD m = new ModulosCRUD();
            gv.DataSource = m.Listmodulo();
            gv.DataBind();
        }
    }
    }
