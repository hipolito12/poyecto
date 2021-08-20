using System;
using System.Collections.Generic;
using System.Text;
using datos;
using System.Data.SqlClient;
using System.Data;



namespace capaNegocios
{
  public  class UsuariosCRUD
    {

        private Usuarios U =  new Usuarios();


        public DataTable muestra()
        {
            DataTable tabla = new DataTable();
            tabla = U.listadoUsuario();
            return tabla;

        }

        public void addU(string idper, string nombre, string nombreU, string apellido, string clave, bool cambia, bool habilit, string email)
        {
            

            U.insertUsuario( idper, nombre, nombreU,apellido,clave,cambia,habilit, email );



        }

        public void EditarU (string idper, string nombre, string nombreU, string apellido, string clave, bool cambia, bool habilit, string email, string id)
        {
            U.updateUsuario(idper, nombre, nombreU, apellido, clave, cambia, habilit, email, Convert.ToInt32(id));
        }

        public void Eliminar(string id)
        {
            U.EliminarUsuario(Convert.ToInt32(id));
        }

    }
}

