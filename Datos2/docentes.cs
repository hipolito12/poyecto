using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos2
{
    public class docentes:Adapter
    {
        public int idcurso { get; set; }

        public int iddictado { get; set; }

        public int iddocente { get; set; }

        public int Cargo { get; set; }

        public DataTable Listar()
        {
            Entidades en = new Entidades();
            string query = "select * from docentes_cursos";
            this.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
            var dt = new DataTable();
            da.Fill(dt);
            this.CloseConnection();
            return dt;
        }
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

            var auxiliar = en.materias
                   .SqlQuery("Select * from materias ")
                   .ToDictionary(t => t.id_materia, t => t.desc_materia);

            var auxiliar1 = en.comisiones
                  .SqlQuery("Select * from comisiones")
                  .ToDictionary(t => t.id_comision, t => t.desc_comision);

            var diccionarioDeTodosLosCursos = en.cursos
                  .SqlQuery($" use tp2 select distinct  * from cursos c  where c.anio_calendario=YEAR(GETDATE()); ")

                  .ToDictionary(t => $" anio : {t.anio_calendario} curso: {auxiliar[t.id_materia]}  comision:{auxiliar1[t.id_comision]} ", t => t.id_curso);

            return (diccionariopersona, diccionarioDeTodosLosCursos);
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
     
