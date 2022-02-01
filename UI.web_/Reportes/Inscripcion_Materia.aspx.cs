using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;

namespace UI.web_.Reportes
{
    public partial class Inscripcion_Materia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblestado.Visible = false;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int secion = Convert.ToInt32(Session["usuario"]);
            _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();
            bool x = ia.VerificarInscripcion(secion, Convert.ToInt32(DropDownList1.SelectedValue));
            if (x == false)
            {
                ia.agregar(secion.ToString(), DropDownList1.SelectedValue, " ", "-1");
                lblestado.Text = "registrado!";

                lblestado.Visible = true;

            }
            else
            {
                lblestado.Text = "  Ya se encuenta registrado!";

                lblestado.Visible = true;
            }
        }
    }
}