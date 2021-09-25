using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos2
{
   
public class modulo
    {
       
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

         conexioncs cone = new conexioncs();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable listarmodulos()
        {
           

            comando.Connection = cone.AbrirConexion();
            comando.CommandText = "ListarModulos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            cone.CerrarConexion();
            return tabla;
        }

     
    }

}
