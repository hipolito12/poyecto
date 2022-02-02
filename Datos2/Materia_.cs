using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
namespace Datos2
{
    public class Materia_:Adapter
    {
        public int idmateria { get; set; }
        public int id_plan { get; set; }
        public string desc_materia { get; set; }
        public int hs_semanales { get; set; }
        public int hs_totales { get; set; }

        //conexioncs conexion = new conexioncs();
        //SqlDataReader leer;
        //DataTable tabla = new DataTable();
        //SqlCommand comando = new SqlCommand();
        public DataTable Listar()
        {
           
            string query = "select * from materias";
            this.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
            var dt = new DataTable();
            da.Fill(dt);
            this.CloseConnection();
            return dt;
        }

        public List <Materia_> listar() 
        {
            Entidades en = new Entidades();
            Entidades entis = new Entidades();

            List<Materia_> lmate = new List<Materia_>();
            string conect = entis.Database.Connection.ConnectionString;
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            string query = "use tp2" +
                " select * from materias";
            SqlCommand cmd = new SqlCommand(query,con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) 
            {
                Materia_ m = new Materia_();
                m.desc_materia = dr.GetString(1);
                m.idmateria = dr.GetInt32(0);
                m.hs_semanales = dr.GetInt32(2);
                m.hs_totales = dr.GetInt32(3);
                lmate.Add(m);
            }
            con.Close();



            return lmate;
        }

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
            //List<string> li = new List<string>();
           


                Entidades entis = new Entidades();
               var  planesList = entis.Database.SqlQuery<string>("select desc_plan from planes").ToList();

                //planes p = new planes();
                //Entidades en = new Entidades();
                //var vari = en.planes;

                //foreach (var per in vari)
                //{
                //    var variab = per.id_plan;
                //    planes pla = en.planes.Where(pl => pl.id_plan == variab).First();
                //    string descripcion = pla.desc_plan;
                //    li.Add(descripcion);

                return planesList ;
                //}
           
            
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

       public List<Materia_> GetOne(int idm) 
        {
            Entidades ent = new Entidades();
          var listmateria = ent.Database.SqlQuery<Materia_>($"select * from materias where materias.id_materia = {idm}").ToList();
            return listmateria;
        }

    }
}
