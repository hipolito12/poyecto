using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using datos;


namespace capaNegocios
{
   public  class PlanCRUD
    {

        private Plan pla = new Plan();


        public DataTable muestra()
        {
            DataTable tabla = new DataTable();
            tabla = pla.listadop();
            return tabla;

        }

        public void addp(string desc,  string espe)
        {


            pla.insertp(desc, Convert.ToInt32(espe));



        }

        public void Editap(string desc, string esp, string id)
        {
            pla.updatep(desc, Convert.ToInt32(esp), Convert.ToInt32(id));
        }

        public void Eliminap(string id)
        {
            pla.Eliminarp(Convert.ToInt32(id));
        }

    }
}

