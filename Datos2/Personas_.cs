using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Datos2
{
    public class Personas_
    {
        Entidades en = new Entidades();
        personas per = new personas();

        public void agregarPersonas(string nombre, string apellido, string direccion, string email, string telefono, string fechan, int legajo, int tipo_persona, int id_plan)
        {
            /*conexioncs conexion = new conexioncs();
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "agregarpersona";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime( fechan));
            comando.Parameters.AddWithValue("@legajo", legajo);
            comando.Parameters.AddWithValue("@tipo", tipo_persona);
            comando.Parameters.AddWithValue("@id_plan", id_plan);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();*/

            Entidades en = new Entidades();

            personas per = new personas();
            per.nombre = nombre;
            per.apellido = apellido;
            per.direccion = direccion;
            per.email = email;
            per.direccion = direccion;
            per.telefono = telefono;
            per.fecha_nac = DateTime.Parse( fechan);
            per.legajo = legajo;
            per.tipo_persona = tipo_persona;
            per.id_plan = id_plan;
            en.personas.Add(per);
            en.SaveChanges();


        }

        public void modificarPersonas(int id, string nombre, string apellido, string direccion, string email, string telefono, string fechan, int legajo, int tipo_persona, int id_plan)
        {


            Entidades en = new Entidades();


            personas person = en.personas.Find(id);
            person.nombre = nombre;
            person.apellido = apellido;
            person.direccion = direccion;
            person.email = email;
            person.direccion = direccion;
            person.telefono = telefono;
            person.fecha_nac = DateTime.Parse(fechan);
            person.legajo = legajo;
            person.tipo_persona = tipo_persona;
            person.id_plan = id_plan;
            en.Entry(person).State=System.Data.Entity.EntityState.Modified;
            en.SaveChanges();




            /* conexioncs conexion = new conexioncs();
             SqlDataReader leer;
             DataTable tabla = new DataTable();
             SqlCommand comando = new SqlCommand();

             comando.Connection = conexion.AbrirConexion();
             comando.CommandText = "actualizar_personas";
             comando.CommandType = CommandType.StoredProcedure;

             comando.Parameters.AddWithValue("@nombre", nombre);
             comando.Parameters.AddWithValue("@id", id);
             comando.Parameters.AddWithValue("@apellido", apellido);
             comando.Parameters.AddWithValue("@direccion", direccion);
             comando.Parameters.AddWithValue("@email", email);
             comando.Parameters.AddWithValue("@telefono", telefono);
             comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime( fechan) );
             comando.Parameters.AddWithValue("@legajo", legajo);
             comando.Parameters.AddWithValue("@tipo", tipo_persona);
             comando.Parameters.AddWithValue("@plan", id_plan);
             comando.ExecuteNonQuery();
             comando.Parameters.Clear();
             conexion.CerrarConexion();*/

        }
        public void eliminarpersonas(int id)
        {
            personas per = en.personas.Find(id);
            en.personas.Remove(per);
            en.SaveChanges();
        }

        public Dictionary<string, int> cargarcombo()
        {

            Dictionary<string, int> person = new Dictionary<string, int>();


            try
            {
                planes p = new planes();
                Entidades en = new Entidades();
                var vari = en.planes;

                foreach (var per in vari)
                {
                    var variab = per.id_plan;
                    planes pla = en.planes.Where(pl => pl.id_plan == variab).First();
                    string descripcion = pla.desc_plan;
                    int id = pla.id_plan;
                    person.Add(descripcion, id);


                }
                return person;
            }
            catch (Exception ex) { Console.Write($"Error: {ex}"); }
            return person;


           


        }

        public List<personas> cargargv()
        {
            Entidades en = new Entidades(); 
            var listaDePersonas= en.personas.SqlQuery("Select * from personas").ToList();
            return listaDePersonas;
        }
    }
}
