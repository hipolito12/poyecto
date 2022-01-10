using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos2;

namespace CapaNegocios
{
    public class Menu_Admin
    {
       

        Menu_Admins ma = new Menu_Admins();
            public List<Menu_Admins> CantidadDeCursosEintegrantes()
        {

            return ma.CantidadDeCursosEintegrantes();
        }

    }
}
