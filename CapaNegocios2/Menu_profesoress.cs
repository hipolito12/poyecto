using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos2;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios
{
     public class Menu_profesores
     {
        Menu_profesoress mo = new Menu_profesoress();
        public DataTable cargarReporte() 
        {
           
            return mo.CargarReporteDeAlumosXcurso();
        }

        public DataTable filtrar( int id) 
        {
            return mo.FiltrarCursos(id);
        }

        public List<int> comboidcurso() 
        {
            return mo.comboidcurso();
        }
        public DataTable cargarInformeDocentesXcurso() 
        {
            return mo.cargarInformeDocentesXcurso();
        }
        public List<alumnos_inscripciones> refrescar() 
        {
            return mo.refrescar(); ;
        }

    }
}
