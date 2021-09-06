﻿using System;
using System.Collections.Generic;
using System.Text;
using Datos2;
using System.Data.SqlClient;
using System.Data;


namespace CapaNegocios2
{
   public class docentes_cursos_CRUD
    {
        private docentes doc = new docentes();

        public void ADDdocenteCURSO(string argo,string idcurso,string iddocente)
        {
            doc.cargardocentes(Convert.ToInt32(argo), Convert.ToInt32(idcurso), Convert.ToInt32(iddocente));
        }

        public void EDITdoceneteCURSO(string argo, string idcurso, string iddocente, string dictado)
        {
            doc.ActualizaDocente(Convert.ToInt32(argo), Convert.ToInt32(idcurso), Convert.ToInt32(iddocente), Convert.ToInt32(dictado));
        }

        public void DELETEdocentesCURSO(string idcurso, string iddocente)
        {
            doc.Delete(Convert.ToInt32(idcurso), Convert.ToInt32(iddocente));
        }
    }
}