﻿using Datos2;
using System;


namespace CapaNegocios
{
    public class Especialidad
    {
        Especilidades esp = new Especilidades();
        public void addEspecialidad(string especilidad)
        {
            esp.agregarespecialidades(especilidad);
        }

        public void Editespecialidades(string id, string especialidades)
        {
            esp.editarespecilidades(Convert.ToInt32(id), especialidades);
        }

        public void delete_especialidad(string id)
        {
            esp.eliminarespecilidad(Convert.ToInt32(id));
        }
    }
}
