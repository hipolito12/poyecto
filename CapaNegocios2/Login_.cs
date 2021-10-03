using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos2;

namespace CapaNegocios
{
    public class Login_
    {
        private _Login lol = new _Login();
        public (string , int)FindRoles(string usuario, string contrasena) 
        {
            return lol.busca_rol(usuario, contrasena); 
        }

        public bool verify(string usu, string contra) 
        {
          bool x=  lol.verifica(usu, contra);
            return x;
        }
        
    }
}
