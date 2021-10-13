using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos2
{
     class Inscripcion_Alumano_
    {
        public void Registro(int alumno, int curso , string condicion, int nota ) 
        {
            Entidades en = new Entidades();
            alumnos_inscripciones ia = new alumnos_inscripciones();

            ia.condicion = condicion;
            ia.id_curso = curso;
            ia.id_alumno = alumno;
            ia.nota = nota;
            en.alumnos_inscripciones.Add(ia);
            en.SaveChanges();

        }
        public void modificacion(int alumno, int curso, string condicion, int nota, int id) 
        {
            Entidades en = new Entidades();
            alumnos_inscripciones ia = new alumnos_inscripciones();
            alumnos_inscripciones ali =en.alumnos_inscripciones.Find(id);
            ia.condicion = condicion;
            ia.id_curso = curso;
            ia.id_alumno = alumno;
            ia.nota = nota;
            ia.id_inscripcion = id;
            en.Entry(ia).State = System.Data.Entity.EntityState.Modified;

        
        }
        public void eliminar(int id) 
        {
            Entidades en = new Entidades();
            
            alumnos_inscripciones ali = en.alumnos_inscripciones.Find(id);
            en.alumnos_inscripciones.Remove(ali);
            en.SaveChanges();
        }

        public List<string> comboalumno()
        {
            Entidades en = new Entidades();
            List<string> lc = new List<string>();
            var es = en.cursos;
            foreach (var k in es)
            {

               // lc.Add(k.);
            }
            return  null;
        }
    }
}
