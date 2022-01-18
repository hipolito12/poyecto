using Datos2;
using System;
using System.Collections.Generic;

namespace CapaNegocios
{
    public class Persona
    {


        Personas_ per = new Personas_();

        public List<personas> listar() 
        {
            return per.listar();
        }

        public void addpersonas(string nombre, string apellido, string direccion, string email, string telefono, string fechan, string legajo, string tipo_persona, string id_plan)
        {
            per.agregarPersonas(nombre, apellido, direccion, email, telefono, fechan, Convert.ToInt32(legajo), Convert.ToInt32(tipo_persona), Convert.ToInt32(id_plan));
        }


        public void modifypersonas(string id, string nombre, string apellido, string direccion, string email, string telefono, string fechan, string legajo, string tipo_persona, string id_plan)
        {
            per.modificarPersonas(Convert.ToInt32(id), nombre, apellido, direccion, email, telefono, fechan, Convert.ToInt32(legajo), Convert.ToInt32(tipo_persona), Convert.ToInt32(id_plan));
            
        }

        public void deletepersonas(string id)
        {
            per.eliminarpersonas(Convert.ToInt32(id));
        }

        public Dictionary<string, int> cargar()
        {

            return per.cargarcombo();
        }


        public List<personas> cargargv() 
        {
            return per.cargargv();
        }
    }


}
