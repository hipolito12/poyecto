using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;
namespace UI.web_.Reportes
{
    public partial class InformeDeNotas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            cargargridview();

        }
        int sum = 0;
        protected void ddlCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        void cargargridview() 
        {
            Notas n = new Notas();
            //int sesion = Convert.ToInt32(Session["usuario"]);
            //string convertir = ddlCursos.SelectedValue.ToString();
            //GridView1.DataSource = n.algo(2020,15);
            //GridView1.DataBind();
        }

       



        //void cargaCombos()
        //{


        //    Notas n = new Notas();
        //    int sesion = Convert.ToInt32(Session["usuario"]);
        //    foreach (var k in n.fechasyparacombo(sesion))
        //    {
        //        ddlCursos.Items.Add(k.anio.ToString());
        //    }

        //}

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            ddlCursos.Visible = false;
                btnAceptar.Attributes.Add("onclick", "imprime()");
            
        }
    }
}