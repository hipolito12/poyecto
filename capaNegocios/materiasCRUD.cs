using System;
using datos;
using System.Data.SqlClient;
using System.Data;

namespace capaNegocios
{

    public class materiasCRUD
    {
        private Materia M = new Materia();


        public DataTable muestra()
        {
            DataTable tabla = new DataTable();
            tabla = M.listado();
            return tabla;

        }

        public void add(string desc, string total, string semanal, string plan)
        {


            M.insertt(desc, Convert.ToInt32(total), Convert.ToInt32(semanal), Convert.ToInt32(plan));



        }

        public void Edita(string desc, string total, string semanal, string plan, string id)
        {
            M.update( desc, Convert.ToInt32(total), Convert.ToInt32(semanal), Convert.ToInt32(plan), Convert.ToInt32(id));
        }

        public void Elimina(string id)
        {
            M.Eliminar(Convert.ToInt32(id));
        }

    } 
}
