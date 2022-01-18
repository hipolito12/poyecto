using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos2;
using System.Threading.Tasks;

namespace CapaNegocios
{
     public class Menu_profesores
     {
        Menu_profesoress mo = new Menu_profesoress();
        public List<Menu_profesoress> cargarReporte() 
        {
           
            return mo.CargarReporteDeAlumosXcurso();
        }

        public List<alumnos_inscripciones> filtrar( int id) 
        {
            return mo.FiltrarCursos(id);
        }

        public List<int> comboidcurso() 
        {
            return mo.comboidcurso();
        }
        public List<Menu_profesoress> cargarInformeDocentesXcurso() 
        {
            return mo.cargarInformeDocentesXcurso();
        }
        public List<alumnos_inscripciones> refrescar() 
        {
            return mo.refrescar(); ;
        }

    }
}
