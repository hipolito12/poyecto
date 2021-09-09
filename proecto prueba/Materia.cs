using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace datos
{




    public class Materia
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        int total, semanal, plan;
        string desc;




        public DataTable listado()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMaterias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public void insertt(string desc, int total, int  semanal, int plan)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@semanales", semanal);
            comando.Parameters.AddWithValue("@totales", total);
            comando.Parameters.AddWithValue("@idplan", plan);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void update(string desc, int total, int semanal, int plan, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@semanales", semanal);
            comando.Parameters.AddWithValue("@totales", total);
            comando.Parameters.AddWithValue("@plan", plan);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "baja";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idMat", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }











        /* static public void Menu()
        {
           
            
            Console.Clear();
            Console.WriteLine("1- Listado general");
            Console.WriteLine("2- Consulta");
            Console.WriteLine("3- Agregar");
            Console.WriteLine("4- Modificar");
            Console.WriteLine("5- Eliminar");
            Console.WriteLine("6- Salir");
           
            int option;
            option = Convert.ToInt32(Console.ReadLine());
            CRUD a = new CRUD();
            switch (option)
            {
                case 1:
                    a.listado();
                    break;
                case 2:

                    break;
                case 3:
                    string desc = Console.ReadLine();
                    int t = Convert.ToInt32(Console.ReadLine());
                    int s = Convert.ToInt32(Console.ReadLine());
                    int p = Convert.ToInt32(Console.ReadLine());

                    a.insertt(desc, t, s, p);


                    break;
                    
                   

       
                case 4:
                    string descr = Console.ReadLine();
                    int te = Convert.ToInt32(Console.ReadLine());
                    int ese = Convert.ToInt32(Console.ReadLine());
                    int pe = Convert.ToInt32(Console.ReadLine());
                    int ide = Convert.ToInt32(Console.ReadLine());
                    a.update( descr,te,ese,pe,ide);

                    
                   

                    break;
                case 5:
                    int id = Convert.ToInt32(Console.ReadLine());
                    a.Eliminar(id);


                    break;



                case 6: 
                    break;
            }
        }*/






    }




}
