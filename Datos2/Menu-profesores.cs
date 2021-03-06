using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos2
{
    public class Menu_profesoress:Adapter
    {
        public  int cantidad { get; set; }
        public int idalumno { get; set; }
        public string docentes { get; set; }
        public string materias { get; set; }

        public List<Menu_profesoress> CargarReporteDeAlumosXcurso( ) 
        {
            string query = "use[tp2] "
                + " select m.desc_materia,  count (ai.id_alumno)as alumnos from alumnos_inscripciones ai "
                + "join cursos c on c.id_curso = ai.id_curso " +
                " join materias m on m.id_materia= c.id_materia " +
                " group by m.desc_materia";




            Entidades en = new Entidades();

            this.OpenConnection();
            SqlCommand cmd = new SqlCommand(query, sqlConn);

            //SqlDataAdapter da = new SqlDataAdapter(query, con);
            //var dt = new DataTable();
            //da.Fill(dt);


            var dr = cmd.ExecuteReader();

            List<Menu_profesoress> mp = new List<Menu_profesoress>();

            while (dr.Read())
            {
                Menu_profesoress m = new Menu_profesoress();

                m.cantidad = dr.GetInt32(1);
                m.docentes = dr.GetString(0);
                mp.Add(m);

            }
            this.CloseConnection();
            return mp;
        }


        public List<int> comboidcurso() 
        {
            Entidades en = new Entidades();
           var ids= en.Database.SqlQuery<int>("select id_curso  from cursos").ToList();
            return ids;
        }

        public DataTable FiltrarCursos( int idcurso) 
        {
            Entidades en = new Entidades();
            this.OpenConnection();

            string query =$"select * from alumnos_inscripciones where id_curso={idcurso} ";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
            var dt = new System.Data.DataTable();
            da.Fill(dt);
            this.CloseConnection();
            return dt;
        }



       public List<Menu_profesoress> cargarInformeDocentesXcurso()
       
        {
            Entidades en = new Entidades();

            

            string query = $" use tp2 " +
           
                    " select CONCAT(p.nombre , ' ', p.apellido) as nombres, m.desc_materia from docentes_cursos dc inner join personas p on p.id_persona = dc.id_docente join cursos c on c.id_curso = dc.id_curso join materias m on m.id_materia = c.id_materia where p.tipo_persona = 1";
            this.OpenConnection();
            SqlCommand cmd = new SqlCommand(query, sqlConn);
          
            var dr = cmd.ExecuteReader();

            List<Menu_profesoress> mp = new List<Menu_profesoress>();

            while (dr.Read())
            {
                Menu_profesoress m = new Menu_profesoress();

                m.docentes = dr.GetString(0);
                m.materias = dr.GetString(1);
                mp.Add(m);

            }
            //SqlDataAdapter da = new SqlDataAdapter(query, con);
            //var dt = new System.Data.DataTable();
            //da.Fill(dt);
            this.CloseConnection();
            return mp;

        }

        public List<alumnos_inscripciones> refrescar()
        {
            Entidades en = new Entidades();
            var k = en.alumnos_inscripciones.SqlQuery($"select * from alumnos_inscripciones  ").ToList();

            return k;
        }

    }
}
