using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos2
{
   
    public class curso_
    {
        conexioncs conexion = new conexioncs();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public Entidades entidad = new Entidades();
        /*public void ADDcursometodoviejo(int idmateria, int idComision, int anio, int cupo) 
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertar_curso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@semanales", semanal);
            comando.Parameters.AddWithValue("@totales", total);
            comando.Parameters.AddWithValue("@idplan", plan);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }*/




        public void ADDcursos( int idmateria, int idComision, int anio, int cupo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertar_curso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idmateria", idmateria);
            comando.Parameters.AddWithValue("@cupo", cupo);
            comando.Parameters.AddWithValue("@aniocal", anio);
            comando.Parameters.AddWithValue("@idcomision", idComision);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void editCursos(int idmateria, int idComision, int anio, int cupo, int idcurso)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editar_curso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcurso", idmateria);
            comando.Parameters.AddWithValue("@idmateria", idmateria);
            comando.Parameters.AddWithValue("@cupo", cupo);
            comando.Parameters.AddWithValue("@anio", anio);
            comando.Parameters.AddWithValue("@idcom", idComision);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    
        public void DleteCusrsos(int idcurso )
        {
            cursos cu = entidad.cursos.Where(c => c.id_curso == idcurso).First();
            entidad.cursos.Remove(cu);
            entidad.SaveChanges();

        
        
        }






        

    }


}
