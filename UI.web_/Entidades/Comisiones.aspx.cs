using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;

namespace UI.web_.Entidades
{
    public partial class Comisiones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGridview();
            error.Visible = false;
        }


        public void cargarGridview()
        {
            Comision com = new Comision();
            GridView1.DataSource = com.cargargrid();
            GridView1.DataBind();

        }







        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDesc_Comision.Text = GridView1.SelectedRow.Cells[2].Text;
            txt_IdPlan.Text = GridView1.SelectedRow.Cells[4].Text;
            txtAnio.Text = GridView1.SelectedRow.Cells[3].Text;

        }



        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Comision com = new Comision();
                if (txtDesc_Comision.Text == null || txtAnio.Text == null || txt_IdPlan.Text == null|| int.Parse(txt_IdPlan.Text) < 0 || int.Parse(txtAnio.Text) < 0)
                {
                    error.Visible = true;
                    GridView1.CssClass = "gridStyles";
                }

                string id = GridView1.SelectedRow.Cells[1].Text;


                com.eliminar_comision(id);
                GridView1.DataSource = com.cargargrid();
                GridView1.DataBind();
            }
            catch (Exception ex) { error.Text = $"{ex}"; error.Visible = true; }
        }



        protected void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                Comision com = new Comision();
                if (txtDesc_Comision.Text == null || txtAnio.Text == null || txt_IdPlan.Text == null || int.Parse(txt_IdPlan.Text) < 0 || int.Parse(txtAnio.Text) < 0)
                {
                    error.Visible = true;
                }

                com.agregar_comisiones(txtDesc_Comision.Text, txtAnio.Text, txt_IdPlan.Text);
                GridView1.DataSource = com.cargargrid();
                GridView1.DataBind();
            }
            catch (Exception ex) { error.Text = $"{ex}"; error.Visible = true; }

        }


        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Comision com = new Comision();
                if (txtDesc_Comision.Text == null || txtAnio.Text == null || txt_IdPlan.Text == null || int.Parse(txt_IdPlan.Text) < 0 || int.Parse(txtAnio.Text) < 0)
                {
                    error.Visible = true;
                }

                string id = GridView1.SelectedRow.Cells[1].Text;
                com.editar_comision(txtDesc_Comision.Text, txtAnio.Text, txt_IdPlan.Text, id);
                GridView1.DataSource = com.cargargrid();
                GridView1.DataBind();
            }
            catch (Exception ex) { error.Text = $"{ex}"; error.Visible = true; }
        }
    }
}