﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;

namespace UI.web_
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Mensaje_error.Visible = false;
            Mensaje_campo_vacio.Visible = false;   
            error.Visible = false;
        }

        protected void boton_registrarme_Click(object sender, EventArgs e)
        {

        }

        protected void boton_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                Login_ lo = new Login_();
                if (l.Text == ""|| contrasena.Text == ""|| l.Text == " " || contrasena.Text == " " || l.Text.Length < 8 || contrasena.Text.Length < 8)
                {
                    Mensaje_campo_vacio.Visible = true;
                }

                if (lo.verify(l.Text, contrasena.Text) == false)
                {
                    Mensaje_error.Text = "usuario no existente";
                    Mensaje_error.Visible = true;
                   
                   
                  
                 
                }

                (string, int) tup;
                tup.Item2 = -1;
                tup.Item1 = " ";

                if (lo.FindRoles(l.Text, contrasena.Text).Item2 != -1)
                {
                    tup = lo.FindRoles(l.Text, contrasena.Text);
                    switch (tup.Item2)
                    {
                        case 1: Response.Redirect(" "); break;
                        case 2: Response.Redirect(" "); break;
                        case 3: Response.Redirect("../Logins/Pagina_Alumnos.aspx"); break;
                    }
                }
                else
                {
                    error.Text = "no existe usuario";
                    error.Visible = true;
                }

            }
            catch ( Exception ex) 
            {
                error.Text = ex.ToString();
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