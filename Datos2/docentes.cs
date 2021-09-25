using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos2
{
    public class docentes
    {

        public void cargardocentes(int cargo, int idcurso, int iddocente)
        {

            Entidades en = new Entidades();
            docentes_cursos dnte = new docentes_cursos();
            dnte.cargo = cargo;
            dnte.id_curso = idcurso;
            dnte.id_docente = iddocente;
            en.docentes_cursos.Add(dnte);
            en.SaveChanges();

        }

         public void ActualizaDocente(int cargo, int idcurso, int iddocente ,int id_dicatado)
         {
            Entidades en = new Entidades();
            docentes_cursos dnte = en.docentes_cursos.Where(d => d.id_dictado == id_dicatado).First();

            dnte.cargo = cargo;
            dnte.id_curso = idcurso;
            dnte.id_docente = iddocente;
            en.Entry(dnte).State= System.Data.Entity.EntityState.Modified;
            en.SaveChanges();
          }


            public void Delete (int id , int idd)
            {
             Entidades en = new Entidades();
             docentes_cursos dnte = en.docentes_cursos.Where(d => d.id_curso == id &&  d.id_docente== idd ).First();
             en.docentes_cursos.Remove(dnte);
             en.SaveChanges();



             }
      


    }

}

