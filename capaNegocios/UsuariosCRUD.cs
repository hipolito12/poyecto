using System;
using System.Collections.Generic;
using System.Text;
using datos;
using System.Data.SqlClient;
using System.Data;



namespace capaNegocios
{
    class UsuariosCRUD
    {

        private Usuarios U =  new Usuarios();


        public DataTable muestra()
        {
            DataTable tabla = new DataTable();
            tabla = U.listadoUsuario();
            return tabla;

        }

        public void addp(string idper, string nombre, string nombreU, string apellido, string clave, string cambia, int habilit, string email)
        {


            U.insertUsuario(idper, nombre, nombreU,apellido,clave,cambia,Convert.ToInt32(habilit), email );



        }

        public void Editapstring (string idper, string nombre, string nombreU, string apellido, string clave, string cambia, int habilit, string email, string id)
        {
            U.updateUsuario(idper, nombre, nombreU, apellido, clave, cambia, Convert.ToInt32(habilit), email, Convert.ToInt32(id));
        }

        public void Eliminap(string id)
        {
            U.EliminarUsuario(Convert.ToInt32(id));
        }

    }
}

