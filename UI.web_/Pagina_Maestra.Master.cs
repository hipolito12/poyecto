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
            //Session["acceso"] = " ";
            //if (Session["acceso"]==null) 
            //{

            //    Response.Redirect("../Logins/Login.aspx");
            //}

            
            

        }

        protected void btnmenu_Click(object sender, EventArgs e)
        {



            try
            {




                
               

                    switch ( Session["acceso"].ToString().Trim())
                    {
                        case "0": Response.Redirect("../Logins/Menu-admins.aspx"); break;

                        case "1": Response.Redirect("../Logins/Menu_Profesores.aspx"); break;

                        case "2": Response.Redirect("../Logins/Menu_Alumno.aspx"); break;

                    }
                
                
            }
            catch (Exception)
            {

                if (Session["acceso"] == null) 
                {
                    Response.Redirect("../Logins/Login.aspx");
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                Session["acceso"] = null;
                Response.Redirect("../Logins/Login.aspx");

            }
            catch (Exception ex) 
            {
                Response.Redirect("../Logins/Login.aspx");
            }
        }

        void verificasecion() 
        {
            //if (Request.Cookies["niveldeacceso"].Value == null) { Response.Redirect("../Logins/Login.aspx"); }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}