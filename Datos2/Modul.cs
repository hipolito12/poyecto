using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Datos2
{
    
        public class modul
        {

             
            private Entidades en = new Entidades();

            public void cargaModulos(string desc,  string ejec)
            {
                modulos mod = new modulos();
                mod.desc_modulo = desc;
               
                mod.ejecuta = ejec;
                en.modulos.Add(mod);
                en.SaveChanges();
            }

            public void EliminaModulo(int id)
            {
                modulos m = en.modulos.Where(f => f.id_modulo == id).First();
                en.modulos.Remove(m);
                en.SaveChanges();

            }

            public void EditarModulo(string desc, int id, string ejec)
            {
                modulos m = en.modulos.Where(f => f.id_modulo == id).First();
                m.ejecuta = ejec;
                m.desc_modulo = desc;
              

                en.Entry(m).State = System.Data.Entity.EntityState.Modified;
                en.SaveChanges();
            }

                private conexion cone = new conexion();
                 SqlDataReader leer;
                 DataTable tabla = new DataTable();
                 SqlCommand comando = new SqlCommand();




        public DataTable listarmodulos ()
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
