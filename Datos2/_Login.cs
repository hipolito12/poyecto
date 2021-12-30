using System;
using System.Linq;

namespace Datos2
{
    public class _Login
    {
        public (string, int ,int) busca_rol(string usuario, string contra)
        {
            Entidades enti = new Entidades();
            personas person = new personas();
            usuarios us = new usuarios();
            try
            {
                us = enti.usuarios.Where(u => u.nombre_usuario == usuario && u.clave == contra).First();

            }
            catch (Exception e)
            {
                throw e;
            }

            if (us != null)
            {
                int usuario_persona = Convert.ToInt32(us.id_persona);
                person = enti.personas.Find(usuario_persona);
                int k = person.tipo_persona;
                string nom = person.nombre;
                int idper = person.id_persona;
                return (nom, k,idper);
            }
            else { return ("-1", -1,-1); }


        }

        public bool verifica(string usuario, string contra)
        {
            Entidades enti = new Entidades();
            usuarios us = new usuarios();
            bool result = false;
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

                throw new Exception("error", e);
            }
            return result;
        }
    }
}
