using System;
using System.Collections.Generic;
using System.Text;
using Datos2;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocios
{
   public class Materia_n
    {

        Materia_ mate = new Materia_();
        public void agregarmateria(string descmat, string hssemanales, string hstotales, string idplan) 
        {
            mate.ADDmaterias(descmat, Convert.ToInt32(hssemanales), Convert.ToInt32(hstotales), Convert.ToInt32(idplan));
        }

     
        public void EditarMaterias(string descmat,string idmateria ,string hssemanales, string hstotales, string idplan) 
        {
            mate.Editmaterias(Convert.ToInt32(idmateria), descmat, Convert.ToInt32(hssemanales), Convert.ToInt32(hstotales), Convert.ToInt32(idplan));
        
        }


        public void eliminarMateria(string idmateria) 
        {
            mate.Delete( Convert.ToInt32(idmateria)  ) ;
        }

    }
}
