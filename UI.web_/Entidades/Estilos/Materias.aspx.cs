using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.web_.Entidades.Estilos
{
    public partial class Materias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           Txtdescripcion.Text = GridView1.SelectedRow.Cells[2].Text;
            Txtsemanales.Text = GridView1.SelectedRow.Cells[3].Text;
            Txttotales.Text = GridView1.SelectedRow.Cells[4].Text;
        }
    }
}