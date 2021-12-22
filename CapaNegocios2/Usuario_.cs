using Datos2;
using System;
using System.Collections.Generic;

namespace CapaNegocios
{
    public class Usuario_
    {
        Usuario us = new Usuario();
        /*  public string idpersona(string mail, string dire, string nombre) 
           {
              string s = us.personaid(mail,dire,nombre);
               return s;
           }*/
        public int ultimo()
        {
            int k = us.ultimoregidtro();
            return k;
        }
        public void agregegarUsuarios(string idper, string nombre, string nombreU, string apellido, string clave, bool cambia, bool habilit, string email)
        {
            us.ADDusuarios(Convert.ToInt32(idper), nombre, nombreU, apellido, clave, cambia, habilit, email);
        }

        public void editUsuarios(string idusuarios, string idper, string nombre, string nombreU, string apellido, string clave, bool cambia, bool habilit, string email)
        {
            us.EditUsuario(Convert.ToInt32(idusuarios), Convert.ToInt32(idper), nombre, nombreU, apellido, clave, cambia, habilit, email);
        }


        public void eliminarUsuarios(string idusuarios)
        {
            us.deleteUsuarios(Convert.ToInt32(idusuarios));
        }
        public List<personas> cargargv() 
        {
            return us.cargargv();
        }
        public Dictionary<string , int> cargarcombo() 
        {
            return  us.cargarcombos() ;
        }
    }
}
