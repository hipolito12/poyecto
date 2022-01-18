using Datos2;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocios
{
    public class ModulosCRUD
    {
        modulo mo = new modulo();

        public List<modulos> listar() 
        {
            return mo.listar();
        }
        public void ADDmodulo(string desc, string ejec)
        {
            mo.cargaModulos(desc, ejec);
        }

        public void Deletemodulo(string id)
        {
            mo.EliminaModulo(Convert.ToInt32(id));
        }

        public void Updatemodulo(string desc, string id, string ejec)
        {
            mo.EditarModulo(desc, Convert.ToInt32(id), ejec);
        }

        public List<modulos>  Listmodulo()
        {


            return mo.listarmodulos(); 
        }

        public Dictionary<string, int> cargador()
        {
            return mo.para_cargar_combos();
        }





    }
}


