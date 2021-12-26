using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
namespace UI.web_
{
    public partial class Pagina_Maestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["acceso"] = "a";
            if (Session["acceso"]==null) 
            {
                
                Response.Redirect("../Logins/Login.aspx");
            }
        }

        protected void btnmenu_Click(object sender, EventArgs e)
        {
           
            var secion = Session["acceso"].ToString();
           
            if (secion != null)
            {
                switch (secion)
                {
                    case "1": Response.Redirect("../Logins/Menu-admins.aspx "); break;

                    case "2": Response.Redirect("../Logins/Menu_Profesores.aspx"); break;

                    case "3": Response.Redirect("../Logins/Menu_Alumno.aspx"); break;

                }
            }
            else 
            {
                Response.Redirect("../Logins/Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Session["acceso"] = null;
            Response.Redirect("../Logins/Login.aspx");
        }
    }
}