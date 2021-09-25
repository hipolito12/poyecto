using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.Entity;
using System.Data.Common;


namespace Datos2
{
  public class Personas_
  {
        Entidades en = new Entidades();
        personas per = new personas();

        public void agregarPersonas(string nombre, string apellido, string direccion, string email, string telefono, string fechan, int legajo, int tipo_persona, int id_plan)
        {
            
   
        
        }

        public void modificarPersonas(int id, string nombre, string apellido, string direccion, string email, string telefono, string fechan, int legajo, int tipo_persona, int id_plan)
        {

        }
        public void eliminarpersonas(int id) 
        {
            personas per = en.personas.Find(id);
            en.personas.Remove(per);
            en.SaveChanges();
        }
    }
}
