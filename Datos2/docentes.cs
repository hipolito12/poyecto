using System.Data;
using System.Linq;
using System.Collections.Generic;
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

        public void ActualizaDocente(int cargo, int idcurso, int iddocente, int id_dicatado)
        {
            Entidades en = new Entidades();
            docentes_cursos dnte = en.docentes_cursos.Where(d => d.id_dictado == id_dicatado).First();

            dnte.cargo = cargo;
            dnte.id_curso = idcurso;
            dnte.id_docente = iddocente;
            en.Entry(dnte).State = System.Data.Entity.EntityState.Modified;
            en.SaveChanges();
        }


        public void Delete(int id, int idd)
        {
            Entidades en = new Entidades();
            docentes_cursos dnte = en.docentes_cursos.Where(d => d.id_curso == id && d.id_docente == idd).First();
            en.docentes_cursos.Remove(dnte);
            en.SaveChanges();



        }


        public ( Dictionary<string, int> , Dictionary<string, int> ) cargar_combo()
        {
            //Dictionary<string, int> PersonsDictionary = new Dictionary<string, int>();
            Dictionary<string, int> cursosDictionary = new Dictionary<string, int>();
            Entidades en = new Entidades();
            var per=en.personas;
            var curso = en.cursos;


            var diccionariopersona = en.personas
                    .SqlQuery("Select * from personas where tipo_persona=1")
                    .ToDictionary(t => $"{t.nombre}  {t.apellido}" , t => t.id_persona);

            foreach (var cu in curso) 
            {
                cursos curaux = en.cursos.Where(cs => cs.id_curso == cu.id_curso).FirstOrDefault();

                materias mat = en.materias.Where(m => curaux.id_materia == m.id_materia ).FirstOrDefault();

                string descripcion = $" materia:{mat.desc_materia}  año : {curaux.anio_calendario } ";
                cursosDictionary.Add(descripcion, curaux.id_curso);
            }

                return (diccionariopersona,cursosDictionary);
        }

        public List<docentes_cursos> cargagv() 
        {

            Entidades ent = new Entidades();
            var ListaDeComisiones = ent.docentes_cursos
                      .SqlQuery("Select * from  docentes_cursos")
                      .ToList();
            return ListaDeComisiones;
        }
    }
}
     
