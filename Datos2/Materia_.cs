using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos2
{
    public class Materia_
    {
        private Entidades en = new Entidades();
        private materias mat = new materias();

        public void ADDmaterias( string descmat,int hssemanales,int hstotales, int idplan) 
        {
            mat.desc_materia = descmat;
            mat.hs_semanales = hssemanales;
            mat.hs_totales = hstotales;
             mat.id_plan = idplan;
            en.materias.Add(mat);
            en.SaveChanges();
        
        } 

        public void Editmaterias(int idmateria, string descmat, int hssemanales, int hstotales, int idplan)
        {
            materias m = en.materias.Where(ma => ma.id_materia == idmateria).First();
            m.hs_semanales = hssemanales;
            m.hs_totales = hstotales;
            m.id_plan = idplan;
            m.desc_materia = descmat;
            m.id_materia = idmateria;
            en.materias.Add(m);
            en.SaveChanges();
        }


        public void Delete( int idmateria)
        {
            materias m = en.materias.Where(ma => ma.id_materia == idmateria).First();
            en.materias.Remove(m);
            en.SaveChanges();

        }

    }
}
