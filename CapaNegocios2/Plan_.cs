using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos2;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocios
{
    class Plan_
    {
        Plan p = new Plan();
        public void agregarplan(string desc, string espe)
        {
            
            p.ADDplan(desc, Convert.ToInt32(espe) );

        }
        public void editplan(string id,string desc, string espe) 
        {
            p.editplan(desc, Convert.ToInt32(espe), Convert.ToInt32(id));
        }

        public void eliminaplan(string id) 
        {
            p.deletePlan(Convert.ToInt32(id));
        }
    }
}
