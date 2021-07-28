using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using proecto_prueba;
using System.Data.SqlClient;
using datos;

namespace negocios_prueba
{
   public class materiasCRUD
    {
        private CRUD M = new CRUD();

        public DataTable muestra()
        {
            DataTable tabla = new DataTable();
            tabla = M.listado();
            return tabla;
        }
    }
}
