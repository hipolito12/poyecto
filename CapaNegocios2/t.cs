using Datos2;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace CapaNegocios
{
    public class Notas
    {
        NotasAlumnos t = new NotasAlumnos();

        public List<NotasAlumnos> algo(int fecha, int idpersona)
        {
          
            return t.alg(fecha, idpersona);

        }

        public List<NotasAlumnos> fechasyparacombo(int idalumno)
        {
            return t.notas(idalumno);
        }
        

    }
    
}
