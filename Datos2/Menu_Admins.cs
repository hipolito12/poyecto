using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos2
{
    public class Menu_Admins
    {
        public int cantidad { get; set; }
        public  string pepe{ get; set; }
        public string Curso { get; set; }
        public string Docentes { get; set; }
        public string Estudiantes { get; set; }


        public List<Menu_Admins> CantidadDeCursosEintegrantes()
        {
            string query = "use tp2" +
                " declare" +
                " @cantidadCurso int,@cantidadMaterias int,@cantidadEstudiantes int ,@cantidadDocentes int " +
                " set @cantidadCurso = (select count (c.id_curso)  from cursos c)  " +
                "set @cantidadDocentes =(select count (d.id_docente)  from docentes_cursos d)" +
                "set @cantidadEstudiantes = (select count (p.id_persona)  from  personas p where p.tipo_persona = 2) set @cantidadMaterias = (select  count (m.id_materia)  from materias m)" +
                "    select CONCAT('cursos :',@cantidadCurso) ,concat( 'docentes: ' ,@cantidadDocentes) ,concat ( 'estudinates :',@cantidadEstudiantes) , concat ('materias: ', @cantidadMaterias)";


            Entidades en = new Entidades();
            //List<mostrar_notas_Result> l = new List<mostrar_notas_Result>(en.mostrar_notas(idper,idcurso));
            SqlConnection con = new SqlConnection(en.Database.Connection.ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            var dr = cmd.ExecuteReader();
            List<int> li = new List<int>();
            int i = 0;
            List<Menu_Admins> lma = new List<Menu_Admins>();
            while (dr.Read())
            {
                Menu_Admins ma = new Menu_Admins();
                ma.pepe= dr.GetString(3);
                ma.Curso = dr.GetString(0);
                ma.Docentes = dr.GetString(1);
                ma.Estudiantes = dr.GetString(2);

                lma.Add(ma);
                ma = null;

            }
            con.Close();
            return lma;
        }


       
    }
}
