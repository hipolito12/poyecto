using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos2
{
   public class Usuario
    {
        Entidades en = new Entidades();
        usuarios u = new usuarios();
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
        }
    
    
        public void EditUsuario(int idUsuarios,int idper, string nombre, string nombreU, string apellido, string clave, bool cambia, bool habilit, string email) 
        {
            usuarios usu = en.usuarios.Where(UsU=> UsU.id_usuario == idUsuarios ).First();
            usu.id_usuario = idUsuarios;
            usu.apellido = apellido;
            usu.email = email;
            usu.id_persona = idper;
            usu.nombre = nombre;
            usu.cambia_clave = cambia;
            usu.nombre_usuario = nombreU;
            usu.habilitado = habilit;
            usu.clave = clave;
            en.usuarios.Add(usu);
            en.SaveChanges();
        }

        public void deleteUsuarios(int idUsuarios) 
        {
            usuarios usu = en.usuarios.Where(UsU => UsU.id_usuario == idUsuarios).First();
            en.usuarios.Remove(usu);
            en.SaveChanges();
        }
    
    }
}
