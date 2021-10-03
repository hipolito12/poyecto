using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos2
{
   public class _Login
    {
        public (string , int) busca_rol(string usuario , string contra) 
        {
            Entidades enti = new Entidades();
            personas person = new personas();
            usuarios us= new usuarios();
            try
            {
                us = enti.usuarios.Where(u => u.nombre_usuario == usuario && u.clave == contra).First();

            }
            catch (Exception e)
            {
                throw e;
            }
            int usuario_persona = Convert.ToInt32(us.id_persona);
            person = enti.personas.Find(usuario_persona);
            int k = person.tipo_persona;
            string nom = person.nombre;
            
            return (nom,k);
        }

        public bool verifica(string usuario, string contra) 
        {
            Entidades enti = new Entidades();
            usuarios us = new usuarios();
            bool result= false;
            try
            {
                us = enti.usuarios.Where(u => u.nombre_usuario == usuario && u.clave == contra).First();
                if (us != null)
                {
                    result = true;
                }
                else { result = false; }
            }
            catch (Exception e)
            {
                
                throw  new Exception("error", e);
            }
            return result;
        }
    }
}
