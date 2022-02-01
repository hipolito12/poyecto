using Datos2;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System;

namespace CapaNegocios

{
    public class _Inscripciones_Alumnos
    {
        Inscripcion_Alumano_ ia = new Inscripcion_Alumano_();
        public void agregar(string idalumno , string curso , string estado , string nota) 
        {
            ia.Registro(  Convert.ToInt32(idalumno), Convert.ToInt32(curso),estado , Convert.ToInt32(nota) );
        }

        public DataTable Listar()
        {
            return ia.Listar();
        }


            public void modificar(string idalumno, string curso, string estado, string nota, string id) 
        {
            Console.WriteLine(curso);
            ia.modificacion(Convert.ToInt32(idalumno), Convert.ToInt32(curso), estado, Convert.ToInt32(nota), Convert.ToInt32(id));
        }


        public void eliminar(string id) 
        {
            ia.eliminar(Convert.ToInt32(id));
        }
    
        public (Dictionary<string, int>, Dictionary<string, int> ,Dictionary<string, int>) cargacombos() 
        {
            return ia.comboalumno();
        }
        public List<alumnos_inscripciones> cargargv() 
        {
            return ia.cargargv();
        }

        public int buscarid_inscripcion(int idalumno, int idcurso) 
        {
            return ia.buscarid_inscripcion(idalumno,idcurso);
        }

        public int buscarPerosnaParaCalificar(int legajo) 
        {
            return ia.buscarPerosnaParaCalificar(legajo);
        }

        public bool VerificarInscripcion(int id, int curso) 
        {
            return ia.VerificarInscripcion(id,curso);
        }
    }
}
