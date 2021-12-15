using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos2;
namespace CapaNegocios
{
    public class Comision
    {
        comision com = new comision();
        public void agregar_comisiones(string descomi, string anio, string idplan) 
        {
            com.agregar_entidades(descomi, Convert.ToInt32(anio) , Convert.ToInt32(idplan));
        }

        public void editar_comision(string descomi, string anio, string idplan ,string idcom ) 
        {
            com.editar_entidad(Convert.ToInt32(idcom),descomi,Convert.ToInt32(anio),Convert.ToInt32(idplan));
        }
        public void eliminar_comision(string  id)  
        {
            com.eliminar_comisiones(Convert.ToInt32( id) );
        }
    
    
       
       public Dictionary<string, int> cargarcombo() 
        {
            return com.cargacombo();
        }
    
       
    public List<comisiones> cargargrid() 
        {
            return com.AgregarGridView();
        }
    }
}
