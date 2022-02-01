using Datos2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocios
{
    public class Materia_n
    {

        Materia_ mate = new Materia_();

        public DataTable listar() 
        {
            return mate.Listar();
        }

        public void agregarmateria(string descmat, string hssemanales, string hstotales, string idplan)
        {
            mate.ADDmaterias(descmat, Convert.ToInt32(hssemanales), Convert.ToInt32(hstotales), Convert.ToInt32(idplan));
        }


        public void EditarMaterias(string descmat, string idmateria, string hssemanales, string hstotales, string idplan)
        {
            mate.Editmaterias(descmat, Convert.ToInt32(hssemanales), Convert.ToInt32(hstotales), Convert.ToInt32(idplan), Convert.ToInt32(idmateria));

        }


        public void eliminarMateria(string idmateria)
        {
            mate.Delete(Convert.ToInt32(idmateria));
        }


        public List<string> carga()
        {
            return mate.Cargar_combos();
        }
        public int busqueda(string con)
        {
            return mate.buscar_id(con);
        }

        public List<materias> cargagv() 
        {
            return mate.cargagv(); ;
        }



        public List<Materia_> lista() 
        {
            return mate.listar();
        }

        public List<Materia_> GetOne(string idm) 
        {
          return  mate.GetOne(Convert.ToInt32(idm));
        }

    }
}
