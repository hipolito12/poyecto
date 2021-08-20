using System;
using System.Collections.Generic;
using System.Text;
using Datos2;
using datos;
using System.Data.SqlClient;
using System.Data;

namespace capaNegocios
{
    public class ModulosCRUD
    {
        private modul mo = new modul();

        public void ADDmodulo(string desc,  string ejec)
        {
            mo.cargaModulos(desc,ejec);
        }

        public void Deletemodulo(int id)
        {
            mo.EliminaModulo(Convert.ToInt32(id));
        }

        public void Updatemodulo(string desc,int id ,string ejec)
        {
            mo.EditarModulo(desc,Convert.ToInt32(id), ejec);
        }

        public DataTable Listmodulo()
        {
            DataTable tabla = new DataTable();
            mo.listarmodulos();
            return tabla;
        }







    }
}
