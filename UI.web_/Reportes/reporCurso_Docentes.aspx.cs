using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;

namespace UI.web_.Reportes
{
    public partial class reportematerias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            cargarReporte();

           
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        public void cargarReporte() 
        {
            Notas n = new Notas();
            gridview.DataSource = n.cargarInformeDocentesXcurso();
            gridview.DataBind();
            

        }

        protected void GridView1_PageIndexChanged(object sender, GridViewPageEventArgs  e)
        {
            gridview.PageIndex = e.NewPageIndex;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            gridview.Attributes.Add("onclick", "imprime()");
            

        }

        
    }
}