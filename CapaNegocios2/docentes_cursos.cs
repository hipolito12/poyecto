using Datos2;
using System;
using System.Collections.Generic;


namespace CapaNegocios
{
    public class docentes_cursos_CRUD
    {
        private docentes doc = new docentes();

        public List<docentes_cursos> Listar() {
            return doc.Listar();
        }


        public void ADDdocenteCURSO(string argo, string idcurso, string iddocente)
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


        public (Dictionary<string, int>, Dictionary<string, int>)  cargaDeCombos() 
        {
            return doc.cargar_combo();
        }

        public List<docentes_cursos> cargagv() 
        {
            return doc.cargagv();
        }
    }
}
