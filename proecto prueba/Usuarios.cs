using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace datos
{
   public  class Usuarios
       
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        




        public DataTable listadoUsuario()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMaterias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public void insertUsuario(string idper, string nombre,string nombreU,string apellido ,string clave, string cambia, int habilit,string email)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpersona", idper);
            comando.Parameters.AddWithValue("@nombreU", nombreU);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@calve", clave);
            comando.Parameters.AddWithValue("@cambia", cambia);
            comando.Parameters.AddWithValue("@habilitado", habilit);
            comando.Parameters.AddWithValue("@email", email);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void updateUsuario(string idper, string nombre, string nombreU, string apellido, string clave, string cambia, int habilit, string email,int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "updateUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpersona", idper);
            comando.Parameters.AddWithValue("@nombreU", nombreU);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@calve", clave);
            comando.Parameters.AddWithValue("@cambia", cambia);
            comando.Parameters.AddWithValue("@habilitado", habilit);
            comando.Parameters.AddWithValue("@email", email); ;
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void EliminarUsuario(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminaUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void consultaUsuario(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "consultarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
