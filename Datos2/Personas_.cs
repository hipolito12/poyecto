using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.Entity;
using System.Data.Common;


namespace Datos2
{
  public class Personas_
  {
        Entidades en = new Entidades();
        personas per = new personas();

        public void agregarPersonas(string nombre, string apellido, string direccion, string email, string telefono, DateTime fechan, int legajo, int tipo_persona, int id_plan)
        {
            conexioncs conexion = new conexioncs();
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
        
             comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "agregarpersona";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idmateria", nombre);
            comando.Parameters.AddWithValue("@cupo", apellido);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@fecha",  fechan);
            comando.Parameters.AddWithValue("@legajo", legajo);
            comando.Parameters.AddWithValue("@tipo", tipo_persona);
            comando.Parameters.AddWithValue("@id_plan", id_plan);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();


        }

        public void modificarPersonas(int id, string nombre, string apellido, string direccion, string email, string telefono, string fechan, int legajo, int tipo_persona, int id_plan)
        {
            conexioncs conexion = new conexioncs();
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "actualizar_personas";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idmateria", nombre);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@cupo", apellido);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@fecha", fechan);
            comando.Parameters.AddWithValue("@legajo", legajo);
            comando.Parameters.AddWithValue("@tipo", tipo_persona);
            comando.Parameters.AddWithValue("@id_plan", id_plan);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void eliminarpersonas(int id) 
        {
            personas per = en.personas.Find(id);
            en.personas.Remove(per);
            en.SaveChanges();
        }
    }
}
