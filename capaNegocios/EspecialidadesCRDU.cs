using System;
using datos;
using System.Data.SqlClient;
using System.Data;
using CapaDeDatos2;

namespace capaNegocios
{
   public  class EspecialidadesCRDU
    {
         modul mo = new modul();
        public  void addModulo(string desc, string id, string ejec) 
        {
            mo.cargaModulos( desc, Convert.ToInt32( id), ejec);
        }

        public void Mostrar() 
        {

        }

        public void eliminar()
        {

        }

        public void Actualizar()
        {

        }


    }
}
