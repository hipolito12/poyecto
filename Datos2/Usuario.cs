using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Datos2
{
    public class Usuario:Adapter
    {

        public int id_usuario { get; set; }

        public string nombre_usuario { get; set; }

        public string clave { get; set; }

        public string nombre { get; set; }

        public string apelldo { get; set; }

        public string email { get; set; }

         public bool habilitado { get; set; }

        public bool cambia_clave { get; set; }

        public int id_persona { get; set; }

        Entidades en = new Entidades();
        usuarios u = new usuarios();

        public DataTable Listar()
        {
            Entidades en = new Entidades();
            string query = "select * from usuarios";
            this.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
            var dt = new DataTable();
            da.Fill(dt);
            this.CloseConnection();
            return dt;
        }
        public void ADDusuarios(int idper, string nombre, string nombreU, string apellido, string clave, bool cambia, bool habilit, string email)
        {
            u.apellido = apellido;
            u.email = email;
            u.id_persona = idper;
            u.nombre = nombre;
            u.cambia_clave = cambia;
            u.nombre_usuario = nombreU;
            u.habilitado = habilit;
            u.clave = clave;
            en.usuarios.Add(u);
            en.SaveChanges();

        }
        /*  public string personaid(string mail, string dire,string nombre) 
          {
              var s = en.personas.Where(pe=> pe.email==mail && pe.direccion == dire && pe.nombre==nombre ).First();
                  return s.id_plan.ToString();
          }*/
        public int ultimoregidtro()
        {
            int k = en.personas.Max(pers => pers.id_persona);
            return k;
        }
        public void EditUsuario(int idUsuarios, int idper, string nombre, string nombreU, string apellido, string clave, bool cambia, bool habilit, string email)
        {
            usuarios usu = en.usuarios.Where(UsU => UsU.id_usuario == idUsuarios).First();

            usu.id_usuario = idUsuarios;
            usu.apellido = apellido;
            usu.email = email;
            usu.id_persona = idper;
            usu.nombre = nombre;
            usu.cambia_clave = cambia;
            usu.nombre_usuario = nombreU;
            usu.habilitado = habilit;
            usu.clave = clave;
            en.Entry(usu).State = System.Data.Entity.EntityState.Modified;
            en.SaveChanges();
        }

        public void deleteUsuarios(int idUsuarios)
        {
            usuarios usu = en.usuarios.Where(UsU => UsU.id_usuario == idUsuarios).First();
            en.usuarios.Remove(usu);
            en.SaveChanges();
        }
        public List<usuarios> cargargv() 
        { Entidades en = new Entidades();

          var persoas= en.usuarios.SqlQuery("Select * from usuarios")
                      .ToList();
            return persoas;
        }

        public Dictionary<string , int > cargarcombos()
        {
            Entidades en = new Entidades();

            var persoas = en.personas.SqlQuery("Select * from personas")
                        .ToDictionary(k=> $"{k.nombre} {k.apellido}", k=> k.id_persona);
            return persoas;
        }


        public List<Usuario> Lista() 
        {
            List<Usuario> lu = new List<Usuario>();
            SqlConnection con = new SqlConnection(en.Database.Connection.ConnectionString);
            string query = "select * from usuarios";
           
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read() ) 
            {
                Usuario u = new Usuario();
                u.nombre_usuario = dr.GetString(1);
                u.clave = dr.GetString(2);
                u.habilitado = dr.GetBoolean(3);
                u.nombre = dr.GetString(4);
                u.apelldo = dr.GetString(5);
                u.email = dr.GetString(6);
                u.cambia_clave = dr.GetBoolean(7);
                u.id_persona = dr.GetInt32(8);
                    lu.Add(u);


            }
            con.Close();
            return lu;
        }

        public List<Usuario> GetOne(int id) 
        {
            var Listusu = en.Database.SqlQuery<Usuario>($"select * from usuarios u where u.id_usuario = {id}").ToList();
            return Listusu;
        }
    
                
    }
}
