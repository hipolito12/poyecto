using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos2
{
    public class Materia_
    {
        conexioncs conexion = new conexioncs();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void ADDmaterias( string descmat,int hssemanales,int hstotales, int idplan) 
        {
          

       

        /* Entidades enti = new Entidades();
         materias mate = new materias();
             mate.desc_materia = descmat;
             mate.hs_semanales = hssemanales;
             mate.hs_totales = hstotales;
             mate.id_plan = idplan;
             enti.materias.Add(mate);
             enti.SaveChanges();*/

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descrip", descmat);
            comando.Parameters.AddWithValue("@semanales", hssemanales);
            comando.Parameters.AddWithValue("@totales", hstotales) ;
            comando.Parameters.AddWithValue("@idplan", idplan);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
             



        }

        public void Editmaterias( string descmat, int hssemanales, int hstotales, int idplan, int idmateria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descrip", descmat);
            comando.Parameters.AddWithValue("@semanales", hssemanales);
            comando.Parameters.AddWithValue("@totales", hstotales);
            comando.Parameters.AddWithValue("@plan", idplan);
            comando.Parameters.AddWithValue("@id", idmateria);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void Delete( int idmateria)
        {
            
            
            Entidades en = new Entidades();
            materias mates = new materias();
            mates = en.materias.Where(ma => ma.id_materia == idmateria).First();
            en.materias.Remove(mates);
            en.SaveChanges();

        }

    }
}
