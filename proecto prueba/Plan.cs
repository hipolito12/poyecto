using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace datos

{
    public class Plan
    {

        private CD_Conexion conexion   = new CD_Conexion(); 
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

            int total, semanal, plan;
            string desc;




            public DataTable listadop()
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "Mostrarplanes";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;
            }


            public void insertp(string desc, int espe)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "insertarplan";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@desc", desc);
                comando.Parameters.AddWithValue("@esp", espe);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }


            public void updatep(string desc, int esp ,int id)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "updateplan";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@des", desc);
                comando.Parameters.AddWithValue("@espe", esp);
                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }


            public void Eliminarp(int id)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "eliminarplan";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }


        public void consultap(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "consultaplan";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }








    }
    }

