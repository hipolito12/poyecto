using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Datos2
{
    public class Materia_
    {
        conexioncs conexion = new conexioncs();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void ADDmaterias(string descmat, int hssemanales, int hstotales, int idplan)
        {




             Entidades enti = new Entidades();
             materias mate = new materias();
                 mate.desc_materia = descmat;
                 mate.hs_semanales = hssemanales;
                 mate.hs_totales = hstotales;
                 mate.id_plan = idplan;
                 enti.materias.Add(mate);
                  enti.SaveChanges();

            /*comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descrip", descmat);
            comando.Parameters.AddWithValue("@semanales", hssemanales);
            comando.Parameters.AddWithValue("@totales", hstotales);
            comando.Parameters.AddWithValue("@idplan", idplan);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();*/




        }

        public void Editmaterias(string descmat, int hssemanales, int hstotales, int idplan, int idmateria)
        {



            Entidades enti = new Entidades();
            materias mate = new materias();
            materias m = enti.materias.Find(idmateria);
            m.desc_materia = descmat;
            m.hs_semanales = hssemanales;
            m.hs_totales = hstotales;
            m.id_plan = idplan;
            enti.Entry(m).State = System.Data.Entity.EntityState.Modified;
            
            enti.SaveChanges();

            /*comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descrip", descmat);
            comando.Parameters.AddWithValue("@semanales", hssemanales);
            comando.Parameters.AddWithValue("@totales", hstotales);
            comando.Parameters.AddWithValue("@plan", idplan);
            comando.Parameters.AddWithValue("@id", idmateria);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();*/
        }


        public void Delete(int idmateria)
        {

            try
            {

                Entidades en = new Entidades();
                materias mates = new materias();
                mates = en.materias.Find(idmateria);
                        en.materias.Remove(mates);
                en.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }
        public List<string> Cargar_combos()
        {
            List<string> li = new List<string>();
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
                    li.Add(descripcion);

                    return li;
                }
            }
            catch (Exception ex) { Console.WriteLine($"Error: {ex}"); }
            return li;
        }


        public int buscar_id(string desc)
        {
            int ID = 0;
            try
            {
                Entidades en = new Entidades();
                planes pl = new planes();
                planes pla = en.planes.Where(plan => plan.desc_plan == desc).First();
                ID = pla.id_plan;
                Console.WriteLine(ID);
                return ID;
            }
            catch (Exception ex) { Console.WriteLine($"Error: {ex}"); }
            return ID;
        }


         public List<materias> cargagv() 
        {
            Entidades ent = new Entidades();
            var ListaDematerias = ent.materias
                      .SqlQuery("Select * from materias")
                      .ToList();
            return ListaDematerias;
        } 


    }
}
