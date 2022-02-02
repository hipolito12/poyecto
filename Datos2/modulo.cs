using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Datos2
{

    public class modulo:Adapter
    {
        public int idmodulo { get; set; }
        public string desc_modulo { get; set; }
        public string ejecuta { get; set; }

        public DataTable Listar()
        {
            
            string query = "select * from modulos";
            this.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, this.sqlConn);
            var dt = new DataTable();
            da.Fill(dt);
            this.CloseConnection();
            return dt;
        }

        public void cargaModulos(string desc, string ejec)
        {
            Entidades en = new Entidades();

            modulos mod = new modulos();
            mod.desc_modulo = desc;

            mod.ejecuta = ejec;
            en.modulos.Add(mod);
            en.SaveChanges();
        }

        public void EliminaModulo(int id)
        {
            Entidades en = new Entidades();
            modulos m = en.modulos.Where(f => f.id_modulo == id).First();
            en.modulos.Remove(m);
            en.SaveChanges();

        }

        public void EditarModulo(string desc, int id, string ejec)
        {
            Entidades en = new Entidades();
            modulos m = en.modulos.Where(f => f.id_modulo == id).First();
            m.ejecuta = ejec;
            m.desc_modulo = desc;


            en.Entry(m).State = System.Data.Entity.EntityState.Modified;
            en.SaveChanges();
        }

        //conexioncs cone = new conexioncs();
        //SqlDataReader leer;
        //DataTable tabla = new DataTable();
        //SqlCommand comando = new SqlCommand();

        public List<modulos> listarmodulos()
        {

            Entidades en = new Entidades();
            var modulos = en.modulos.SqlQuery("Select * from modulos").ToList();
            return modulos;
        }

        public Dictionary<string, int> para_cargar_combos()
        {
            Entidades en = new Entidades();
            var mod = en.modulos;
            Dictionary<string, int> cm = new Dictionary<string, int>();
            foreach (var vari in mod)
            {
                cm.Add(vari.desc_modulo, vari.id_modulo);
            }
            return cm;

        }

    }

}
