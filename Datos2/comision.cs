using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;

namespace Datos2
{
    public class comision
    {
        public int idplan { get; set; }
        public int anio { get; set; }
        public string descripcion { get; set; }
        public int idcomision { get; set; }


        public DataTable Listar() 
        {
            Entidades en = new Entidades();
            string query = "select * from comisiones";
            SqlConnection con = new SqlConnection(en.Database.Connection.ConnectionString);
             SqlDataAdapter da = new SqlDataAdapter(query,con);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        } 

        public void agregar_entidades( string descomi,int  anio,int idplan)
        {
            Entidades en = new Entidades();
            comisiones com = new comisiones();

          
            com.id_plan= idplan;
            com.desc_comision = descomi;
            com.anio_especialidad = anio;
            en.comisiones.Add(com);
            en.SaveChanges();

        }

        public void editar_entidad(int idcom, string descomi, int anio, int idplan)
        {
            Entidades en = new Entidades();

            comisiones comis = en.comisiones.Where(c => c.id_comision == idcom).FirstOrDefault();

            comis.desc_comision = descomi;
            comis.anio_especialidad = anio;
            comis.id_plan = idplan;
            en.Entry(comis).State = System.Data.Entity.EntityState.Modified;
            en.SaveChanges();
        }
    
    
          public void eliminar_comisiones(int id) 
          {
            try
            {
                Entidades en = new Entidades();

                comisiones comis = en.comisiones.Where(c => c.id_comision == id).FirstOrDefault();
                en.comisiones.Remove(comis);
                en.SaveChanges();
            }
            catch(Exception ex) { throw ex; }
            
            
          }


        public Dictionary<string, int> cargacombo()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Entidades en = new Entidades();
            var pl = en.planes;
            foreach (var k in pl)
            {
                planes pla = en.planes.Where(p => p.id_plan == k.id_plan).FirstOrDefault();
                dict.Add(pla.desc_plan, pla.id_plan);
            }


            return dict;
        }

        public List<comisiones> AgregarGridView()
        {
            Entidades ent = new Entidades();
             var ListaDeComisiones = ent.comisiones
                       .SqlQuery("Select * from comisiones")
                       .ToList();
            
            return ListaDeComisiones;
        }
    }
}
