using Datos2;
using System;
using System.Collections.Generic;

namespace CapaNegocios
{
    public class Plan_
    {

        Plan p = new Plan();

        public Dictionary<string, int> cargargarcombos()
        {
            return p.cargarCB();
        }
        public void agregarplan(string desc, string espe)
        {

            p.ADDplan(desc, Convert.ToInt32(espe));

        }
        public void editplan(string id, string desc, string espe)
        {
            p.editplan(desc, Convert.ToInt32(espe), Convert.ToInt32(id));
        }

        public void eliminaplan(string id)
        {
            p.deletePlan(Convert.ToInt32(id));
        }

        public List<planes> cargargv() 
        {
            return p.cargargv() ;
        }
    }
}
