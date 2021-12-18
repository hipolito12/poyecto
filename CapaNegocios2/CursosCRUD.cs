using Datos2;
using System;
using System.Collections.Generic;

namespace CapaNegocios
{
    public class CursosCRUD
    {
        curso_ c = new curso_();

        public void agregarCurso(string materia, string comision, string cupo, string anio)
        {
            c.ADDcursos(Convert.ToInt32(materia), Convert.ToInt32(comision), Convert.ToInt32(cupo), Convert.ToInt32(anio));

        }

        public void EditarCurso(string curso, string comision, string cupo, string anio, string materia)
        {
            c.editCursos(Convert.ToInt32(materia), Convert.ToInt32(comision), Convert.ToInt32(anio), Convert.ToInt32(cupo), Convert.ToInt32(curso));
        }

        public void elimminarcurso(string id)
        {
            c.DleteCusrsos(Convert.ToInt32(id));
        }

        public (Dictionary<string, int>, Dictionary<string, int>) devuelv_combo()
        {

            return c.devuelve_datos_de_combo();
        }

        public List<cursos> cargargridview() 
        {
            return c.cargargridview();
        }
    }
}
