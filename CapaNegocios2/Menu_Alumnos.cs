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

        public DataTable algo(int fecha, int idpersona)
        {
          
            return t.alg(fecha, idpersona);

        }

        public List<DataRow> fechasyparacombo(int idalumno)
        {
            return t.notas(idalumno);
        }

        public DataTable cargarInformeDocentesXcurso()
        {
            return t.cargarInformeDocentesXcurso();
        }

        public bool verifyActualPass(int id, string pass) 
        {
            return t.verifyActualPass(id, pass);
        }

        public void cambiarContrasena(int id, string newpass) 
        {
            t.cambiarContrasena(id,newpass);
        }
    }
    
}
