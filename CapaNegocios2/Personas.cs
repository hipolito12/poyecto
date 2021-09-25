using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos2;

namespace CapaNegocios
{
   public  class Persona
    {
        Personas_ per = new Personas_();
        public void addpersonas(string nombre, string apellido, string direccion, string email, string telefono, string fechan, string legajo, string tipo_persona, string  id_plan)
        {
            per.agregarPersonas(nombre, apellido, direccion, email, telefono, fechan, Convert.ToInt32 (legajo),Convert.ToInt32 (tipo_persona), Convert.ToInt32 (id_plan) );
        }


        public void modifypersonas(string id, string nombre, string apellido, string direccion, string email, string telefono, string fechan, string legajo, string tipo_persona, string id_plan) 
        {
            per.modificarPersonas(Convert.ToInt32(id) , nombre , apellido, direccion, email, telefono, fechan,Convert.ToInt32( legajo) , Convert.ToInt32(tipo_persona) , Convert.ToInt32(id_plan)  );
        }
        
        public void deletepersonas(string id) 
        {
            per.eliminarpersonas( Convert.ToInt32(id) );
        }
  }

   
}
