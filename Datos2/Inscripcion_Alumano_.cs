using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Datos2
{
    public class Inscripcion_Alumano_
    {
        public void Registro(int alumno, int curso, string condicion, int nota)
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
            Console.WriteLine(curso);
            Entidades en = new Entidades();
            alumnos_inscripciones ia = new alumnos_inscripciones();
            alumnos_inscripciones ali = en.alumnos_inscripciones.Find(id);
            ali.condicion = condicion;
            
            ali.id_curso = curso;
           
            ali.id_alumno = alumno;
            ali.nota = nota;
            
            en.Entry(ali).State = System.Data.Entity.EntityState.Modified;
            en.SaveChanges();

        }
        public void eliminar(int id)
        {
            Entidades en = new Entidades();

            alumnos_inscripciones ali = en.alumnos_inscripciones.Find(id);
            en.alumnos_inscripciones.Remove(ali);
            en.SaveChanges();
        }

        public (Dictionary<string ,int>, Dictionary<string, int>) comboalumno()
        {
            Entidades en = new Entidades();

            var diccionariopersona = en.personas
                     .SqlQuery("Select * from personas where tipo_persona=2")
                     .ToDictionary(t => $" {t.legajo}   {t.nombre} {t.apellido}", t => t.id_persona);

            var auxiliar = en.materias
                    .SqlQuery("Select * from materias ")
                    .ToDictionary(t => t.id_materia  ,t=>t.desc_materia);

            var diccionariocursos = en.cursos
                   .SqlQuery("Select * from cursos")
                   .ToDictionary(t => $" materia:{ auxiliar[t.id_materia]} || año:{t.anio_calendario}", t => t.id_curso);



            return (diccionariopersona,diccionariocursos);

        }

        public List<alumnos_inscripciones> cargargv() 
        {
            Entidades en = new Entidades();
            var auxiliar = en.alumnos_inscripciones
                   .SqlQuery("Select * from alumnos_inscripciones ")
                   .ToList();
            return auxiliar;
        }

        public int buscarid_inscripcion(int idalumno,int idcurso) 
        {
            Entidades en = new Entidades();
            alumnos_inscripciones ai = en.alumnos_inscripciones.Where(a => a.id_alumno == idalumno && a.id_curso == idcurso).First();
            int id = ai.id_inscripcion;
            return id;
        }

        public int   buscarPerosnaParaCalificar(int   legajo) 
        {
            Entidades en = new Entidades();
            personas p = en.personas.Where(per => per.legajo ==  legajo).FirstOrDefault();
           
            return p.id_persona;
        }
    }
}
