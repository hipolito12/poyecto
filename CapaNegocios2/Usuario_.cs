using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos2;
using System.Data.SqlClient;
using System.Data;


namespace CapaNegocios
{
    class Usuario_
    {
        Usuario us = new Usuario();
        public void agregegarUsuarios(string idper, string nombre, string nombreU, string apellido, string clave, bool cambia, bool habilit, string email) 
        {
            us.ADDusuarios(Convert.ToInt32(idper) , nombre,  nombreU, apellido,  clave, cambia, habilit,  email);
        }
        
        public void editUsuarios(int idusuarios ,string idper, string nombre, string nombreU, string apellido, string clave, bool cambia, bool habilit, string email) 
        {
            us.EditUsuario(Convert.ToInt32(idusuarios),Convert.ToInt32(idper), nombre, nombreU, apellido, clave, cambia, habilit, email);
        }


        public void eliminarUsuarios(int idusuarios)
        {
            us.deleteUsuarios(idusuarios);
        }

    }
}
