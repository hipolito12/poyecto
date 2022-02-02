using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Datos2
{
    public class Inscripcion_Alumano_:Adapter
    {

        public int idinscripcion { get; set; }
        public int idalumno { get; set; }
        public int idcurso { get; set; }
        public string  condicion { get; set; }
        public int nota { get; set; }


        public DataTable Listar()
        {
           
            string query = "select * from alumnos_inscripciones";
            this.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
            var dt = new DataTable();
            da.Fill(dt);
            this.CloseConnection();
            return dt;
        }
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
            // ver aca que onda y mucha suerte entendiendo el spagueti code
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

        public (Dictionary<string ,int>, Dictionary<string, int >, Dictionary<string, int>) comboalumno()
        {
            Entidades en = new Entidades();

            var diccionariopersona = en.personas
                     .SqlQuery("Select * from personas where tipo_persona=2")
                     .ToDictionary(t => $" {t.legajo}   {t.nombre} {t.apellido}", t => t.id_persona);

            var auxiliar = en.materias
                    .SqlQuery("Select * from materias ")
                    .ToDictionary(t => t.id_materia  ,t=>t.desc_materia);

            var diccionariocursos = en.cursos
                   .SqlQuery($" select * from cursos  where anio_calendario = { DateTime.Now.Year}")
            
                   .ToDictionary(t => $" anio : {t.anio_calendario} curso: {auxiliar[t.id_materia]}" , t => t.id_curso  );

            var diccionarioDeTodosLosCursos = en.cursos
                  .SqlQuery($" select * from cursos  ")

                  .ToDictionary(t => $" anio : {t.anio_calendario} curso: {auxiliar[t.id_materia]}", t => t.id_curso);

            return (diccionariopersona,diccionariocursos,diccionarioDeTodosLosCursos);

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

        public bool VerificarInscripcion( int id , int curso) 
        {
            bool verifica = false;
            Entidades en = new Entidades();
           var alumno= en.alumnos_inscripciones.Where(k => k.id_alumno == id && k.id_curso == curso).FirstOrDefault();
            if (alumno == null) 
            {
                return verifica ;

            }
            return verifica =true;
        }


        //public bool verificarInscripcion(int alumno) 
        //{
        //    bool x = false;
        //    Entidades en = new Entidades();
        //    alumnos_inscripciones ai = en.alumnos_inscripciones.Where(a => a.id_alumno == 15).FirstOrDefault();
        //    if (ai != null)
        //    {
        //        x = true;
        //        return x;
        //    }
        //    else { return x; }
        //}

    }
}
