using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos2;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocios2
{
    class CursosCRUD
    {
        curso c = new curso();
        
        public void agregarCurso(string materia, string comision, string cupo, string anio)
        {
            c.ADDcursos(Convert.ToInt32(materia), Convert.ToInt32(comision), Convert.ToInt32(cupo), Convert.ToInt32(anio));
        
        }

        public void EditarCurso(string curso, string comision, string cupo, string anio, string materia)
        {
            c.editCursos(Convert.ToInt32(materia), Convert.ToInt32(comision), Convert.ToInt32(anio), Convert.ToInt32(cupo), Convert.ToInt32(curso));
        }
    
        public void elimminarcurso(string com,string anio,string curso,int materia)
        {
            c.DleteCusrsos(Convert.ToInt32(com), Convert.ToInt32(anio), Convert.ToInt32(curso) ,Convert.ToInt32(materia));
        }
    
        
    }
}
