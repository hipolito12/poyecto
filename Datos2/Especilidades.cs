using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace Datos2
{
    public class Especilidades:Adapter
    {

        public int idespecialdiad { get; set; }
        public string  desc_especialidad { get; set; }

        Entidades en = new Entidades();
        especialidades es = new especialidades();

        public DataTable Listar()
        {
            
            string query = "select * from especialidades";
            this.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
            var dt = new DataTable();
            da.Fill(dt);
            this.CloseConnection();
            return dt;
        }

        public void agregarespecialidades(string descripcion)
        {
            es.desc_especialidad = descripcion;
            en.especialidades.Add(es);
            en.SaveChanges();
        }
        public void editarespecilidades(int id, string decrip)
        {
            especialidades espe = en.especialidades.Where(e => e.id_especialidad == id).First();
            espe.desc_especialidad = decrip;
            en.Entry(espe).State = System.Data.Entity.EntityState.Modified;
            en.SaveChanges();
        }
        public void eliminarespecilidad(int id)
        {
            especialidades espe = en.especialidades.Where(e => e.id_especialidad == id).First();
            en.especialidades.Remove(espe);
            en.SaveChanges();

        }

        public List<especialidades> Cargagv() 
        {
            Entidades ent = new Entidades();
            var ListaDeespecialidades = ent.especialidades
                      .SqlQuery("Select * from especialidades")
                      .ToList();
            return ListaDeespecialidades;
        }
    }
}
