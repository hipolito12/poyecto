using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;
namespace UI.web_.Reportes
{
    public partial class CursosEintegrantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargargridview();

        }

        protected void btnImprime_Click(object sender, EventArgs e)
        {
            btnImprime.Attributes.Add("onclick", "imprime()");
        }


        void cargargridview()
        {
            Menu_Admin ma = new Menu_Admin();
            GridView1.DataSource = ma.CantidadDeCursosEintegrantes();
          
            GridView1.DataBind();
        }
    }
}