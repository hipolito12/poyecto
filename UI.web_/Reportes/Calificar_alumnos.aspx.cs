using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;
namespace UI.web_.Reportes
{
    public partial class Calificar_alumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblinformar.Visible = false;
        }
        public int k;
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();
            TextBox1.Text = GridView1.SelectedRow.Cells[5].Text;
           
          // k  = ia.buscarPerosnaParaCalificar(Convert.ToInt32(GridView1.SelectedRow.Cells[2].Text));
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {  if (TextBox1.Text != null)
                {
                    _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();
                    //metodo para tarer el idinscripcion
                    int ka = ia.buscarPerosnaParaCalificar(Convert.ToInt32(GridView1.SelectedRow.Cells[2].Text));
                    
                    int idinscrip = ia.buscarid_inscripcion(ka, Convert.ToInt32(DropDownList1.SelectedValue));
                    ia.modificar(ka.ToString(), DropDownList1.SelectedValue, DropDownList2.SelectedValue, TextBox1.Text, idinscrip.ToString());


                    lblinformar.Text = "registrado!";

                    lblinformar.Visible = true;
                    GridView1.DataBind();
                }
                else
                {
                    lblinformar.Text = "ha ocurrido un error , verifique la entrada  e intente de nuevo";
                    lblinformar.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblinformar.Text = /*"ha ocurrido un error , verifique la entrada  e intente de nuevo"*/  ex.Message ;
                lblinformar.Visible = true;
            }
        }
    }
}