﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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




        public void ADDcursos(int idmateria, int idComision, int anio, int cupo)
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
            comando.Parameters.AddWithValue("@idcurso", idcurso);
            comando.Parameters.AddWithValue("@idmateria", idmateria);
            comando.Parameters.AddWithValue("@cupo", cupo);
            comando.Parameters.AddWithValue("@anio", anio);
            comando.Parameters.AddWithValue("@idcom", idComision);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void DleteCusrsos(int idcurso)
        {
            cursos cu = entidad.cursos.Where(c => c.id_curso == idcurso).FirstOrDefault();
            entidad.cursos.Remove(cu);
            entidad.SaveChanges();



        }


        public (Dictionary<string, int>, Dictionary<string, int>) devuelve_datos_de_combo()
        {
            Dictionary<string, int> mate = new Dictionary<string, int>();
            Dictionary<string, int> c = new Dictionary<string, int>();
            try
            {

                Entidades en = new Entidades();
                comisiones com = new comisiones();
                materias mat = new materias();
                var vari = en.comisiones;

                foreach (var comis in vari)//comisiones
                {
                    var variab = comis.id_comision;
                    comisiones co = en.comisiones.Where(comi => comi.id_comision == variab).First();
                    string descripcion = co.desc_comision;
                    int key1 = co.id_comision;
                    c.Add(descripcion, key1);

                }
                var varia = en.materias;
                foreach (var ma in varia)//materias
                {
                    var variab = ma.id_materia;
                    materias m = en.materias.Where(materi => materi.id_materia == variab).First();
                    string descripcion = m.desc_materia;
                    int key2 = m.id_materia;
                    mate.Add(descripcion, key2);

                }

            }
            catch (Exception ex) { Console.WriteLine($"Error: {ex}"); }

            return (mate, c);
        }





    }


}
