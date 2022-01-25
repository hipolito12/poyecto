using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Datos2
{
    public class Plan
    {

        public int id_plan { get; set; }
        public string desc_plan { get; set; }
        public int id_especialidad { get; set; }




        Entidades en = new Entidades();
        planes pl = new planes();


        public DataTable Listar()
        {
            Entidades en = new Entidades();
            string query = "select * from planes";
            SqlConnection con = new SqlConnection(en.Database.Connection.ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void ADDplan(string desc, int espe)
        {
            pl.desc_plan = desc;
            pl.id_especialidad = espe;
            en.planes.Add(pl);
            en.SaveChanges();
        }


        public void editplan(string desc, int espe, int id)
        {
            planes pl = en.planes.Where(plan => plan.id_plan == id).First();
            pl.id_especialidad = espe;
            pl.desc_plan = desc;
            pl.id_plan = id;
            en.Entry(pl).State = System.Data.Entity.EntityState.Modified;
            en.SaveChanges();

        }

        public void deletePlan(int id)
        {
            planes pl = en.planes.Where(plan => plan.id_plan == id).First();
            en.planes.Remove(pl);
            en.SaveChanges();
        }


        public Dictionary<string, int> cargarCB()
        {
            especialidades esp = new especialidades();
            Entidades en = new Entidades();
            Dictionary<string, int> lc = new Dictionary<string, int>();
            var es = en.especialidades;
            foreach (var k in es)
            {

                lc.Add(k.desc_especialidad, k.id_especialidad);
            }
            return lc;
        }
    
    
        public List<planes> cargargv() 
        {
            Entidades ent = new Entidades();
            var ListaDePlanes = ent.planes
                      .SqlQuery("Select * from planes")
                      .ToList();
            return ListaDePlanes;
        }
    
    }



}
