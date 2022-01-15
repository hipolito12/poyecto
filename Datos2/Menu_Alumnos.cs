using System;
using System.Data.SqlClient;
using System.Data;
 using System.Collections.Generic;
using System.Linq;


namespace Datos2
{
    public class NotasAlumnos
    {
        public int Nota {get;set; }
        public string situacion { get; set; }
        public string materia { get; set; }
        public int anio { get; set; }
        public List<NotasAlumnos> alg(int fecha, int idper)
        {
            string query = "use[tp2] " +
                 " select m.desc_materia  ,nota ,condicion " +
                "from alumnos_inscripciones ai inner join cursos c on c.id_curso = ai.id_curso " +
                "inner join materias m on m.id_materia = c.id_materia " +
                $"where ai.id_alumno = {idper}  and c.anio_calendario = {fecha}";




            Entidades en = new Entidades();
            //List<mostrar_notas_Result> l = new List<mostrar_notas_Result>(en.mostrar_notas(idper,idcurso));
            SqlConnection con = new SqlConnection(en.Database.Connection.ConnectionString);
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            var dr = cmd.ExecuteReader();
             
             List<NotasAlumnos> a = new List<NotasAlumnos>();

             while (dr.Read()) 
             {
                NotasAlumnos t = new NotasAlumnos();
                
                 t.Nota = dr.GetInt32(1);
                 t.situacion = dr.GetString(2);
                 t.materia = dr.GetString(0);
                Console.WriteLine();
                 a.Add(t);
                
             }
             con.Close();
           // DataTable dt = new DataTable();
            //dt.Load(dr);
            //dr.Dispose();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);

            return a ;
        }

       public List<NotasAlumnos> notas(int idalumno ) 
        
        {

            string query = "use[tp2]"
                + $"select  c.anio_calendario from alumnos_inscripciones  ai  inner join cursos c on c.id_curso = ai.id_curso where ai.id_alumno = {idalumno} ;";


            Entidades en = new Entidades();
            
            SqlConnection con = new SqlConnection(en.Database.Connection.ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr  = cmd.ExecuteReader();

            List<NotasAlumnos> nal = new List<NotasAlumnos>();

            while (dr.Read())
            {
                NotasAlumnos t = new NotasAlumnos();

                t.anio = dr.GetInt32(0);
                Console.WriteLine();
                nal.Add(t);

            }
            con.Close();

            return nal;
        }

        /*static void Main(string[] args)
        {
            NotasAlumnos na = new NotasAlumnos();
            foreach (var k in na.notas(15))
            { Console.WriteLine(k.anio);
                

            }
            Console.ReadLine();
        }*/


        public List<Menu_profesoress> cargarInformeDocentesXcurso()

        {
            Entidades en = new Entidades();

            string query = $" use tp2 " +
                "select   CONCAT( p.nombre , p.apellido) as nombres, dc.id_curso from   docentes_cursos dc inner join personas p on p.id_persona = dc.id_docente ";
            SqlConnection con = new SqlConnection(en.Database.Connection.ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            var dr = cmd.ExecuteReader();

            List<Menu_profesoress> mp = new List<Menu_profesoress>();

            while (dr.Read())
            {
                Menu_profesoress m = new Menu_profesoress();

                m.docentes = dr.GetString(0);
                m.idalumno = dr.GetInt32(1);
                mp.Add(m);

            }
            con.Close();
            return mp;
        }


        public bool verifyActualPass(int id , string pass) 
        {
            try
            {

                bool result = false;

                Entidades En = new Entidades();
                usuarios u = En.usuarios.Where(us => us.id_persona == id).FirstOrDefault();

                if (u.clave == pass)
                {
                    result = true;
                }

                return result;
            }
            catch (Exception ex)
            {

                throw ex; 
            }



        }

        public void cambiarContrasena(int id ,string newpass) 
        {
            try
            {
                Entidades En = new Entidades();
                usuarios u = En.usuarios.Where(us => us.id_persona == id).FirstOrDefault();
                u.clave = newpass;
                u.cambia_clave = true;
                En.Entry(u).State = System.Data.Entity.EntityState.Modified;
                En.SaveChanges();
            }
            catch (Exception ex)
            {

                throw  ex ;
            }
        }

    }
}
