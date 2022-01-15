using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.web_.Reportes
{
    public partial class CambiarContrasena : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncambiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtactual.Text == null || txtnuevamente.Text == null || txtnueva.Text == null || txtnuevamente.Text != txtnueva.Text || txtnuevamente.Text.Length < 8 || txtnueva.Text.Length < 8)
                {
                    lblinformar.Text =
                        ("hay  un error , verifique su entrada");
                    lblinformar.Visible = true;
                }
                Notas n = new Notas();
                bool result = n.verifyActualPass(Convert.ToInt32( Session["usuario"]), txtactual.Text);

                if (result == true)
                {
                    n.cambiarContrasena(Convert.ToInt32(Session["usuario"]), txtnueva.Text);
                   lblinformar.Text=("Modificada!");
                    lblinformar.Visible = true;
                }
                else { lblinformar.Text=("contraseña actual invalida "); lblinformar.Visible = true; }
            }
            catch (Exception ex)
            {

                lblinformar.Text=("Ocurrio un error, intentelo nuevamente!");
                lblinformar.Visible = true;
            }
        }
    }
}