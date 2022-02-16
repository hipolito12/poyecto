using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;
using System.Web.SessionState;
using System.Text.RegularExpressions;

namespace UI.web_
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Mensaje_error.Visible = false;
            Mensaje_campo_vacio.Visible = false;   
            error.Visible = false;
            Session["acceso"] = null;
        }

        protected void boton_registrarme_Click(object sender, EventArgs e)
        {

        }

        protected void boton_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                Login_ lo = new Login_();
                if (l.Text != "" && contrasena.Text != "" && l.Text != "" && contrasena.Text != "" && l.Text.Length >= 8 && contrasena.Text.Length >= 8 &&  Regex.IsMatch(l.Text,"[a-z,A-Z,0-9]" )==true && Regex.IsMatch(contrasena.Text, "[a-z,A-Z,0-9]") == true)
                {



                    if (lo.verify(l.Text, contrasena.Text) != false)
                    {







                        (string, int, int) tup;
                        tup.Item2 = -1;
                        tup.Item1 = " ";
                        tup.Item3 = -1;

                        if (lo.FindRoles(l.Text, contrasena.Text).Item2 != -1)
                        {
                            tup = lo.FindRoles(l.Text, contrasena.Text);
                            //if (Request.Cookies["niveldeacceso"] != null)
                            //{

                            //}
                            //else
                            //{
                            //    HttpCookie ck = new HttpCookie("niveldeacceso");
                            //    ck.Value = tup.Item2.ToString();
                            //    ck.Expires = DateTime.Now.AddMinutes(5);
                            //    Response.Cookies.Add(ck);

                            //}

                            switch (tup.Item2) //creo una sesion 
                            {
                                case 0: Session["acceso"] = tup.Item2.ToString(); Response.Redirect("../Logins/Menu-admins.aspx"); break;
                                    
                                case 1: Session["acceso"] = tup.Item2.ToString(); Session["usuarioprofe"] = tup.Item3; Response.Redirect("../Logins/Menu_Profesores.aspx"); break;

                                case 2: Session["acceso"] = tup.Item2.ToString(); Session["usuario"] = tup.Item3; Response.Redirect("../Logins/Menu_Alumno.aspx"); break;
                            }

                        }
                        else
                        {
                            error.Text = "no existe usuario";
                            error.Visible = true;
                        }
                    }
                    else
                    {
                        Mensaje_error.Text = "usuario no existente";
                        Mensaje_error.Visible = true;
                    }
                }
                    else { Mensaje_campo_vacio.Visible = true; }
               
            }
            catch ( Exception ex) 
            {
                error.Text = " Ha ocurrido un error! Intente nuevamente  ";
                error.Visible = true ;
            }
            
        }

        protected void l_TextChanged(object sender, EventArgs e)
        {

        }

        protected void boton_registrarme_Click1(object sender, EventArgs e)
        {

        }
    }
}