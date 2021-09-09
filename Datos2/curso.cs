using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos2
{
    public class curso
    {
        Entidades en = new Entidades();
        cursos cus = new cursos();
       
        public void ADDcursos( int idmateria, int idComision, int anio, int cupo)
        {
            cus.cupo = cupo;
            cus.id_comision = idComision;
            cus.anio_calendario = anio;
            cus.id_materia = idmateria;
            en.cursos.Add(cus);
            en.SaveChanges();


        }


        public void editCursos(int idmateria, int idComision, int anio, int cupo, int idcurso)
        {
            cursos cU = en.cursos.Where( c => c.id_comision == idComision && c.anio_calendario== anio && c.id_curso== idcurso && c.id_materia== idmateria).First();

            cU.cupo = cupo;
            cU.id_comision = idComision;
            cU.anio_calendario = anio;
            cU.id_materia = idmateria;
            cU.id_curso = idcurso;
            en.cursos.Add(cU);
            en.SaveChanges();
        }
    
        public void DleteCusrsos(int com , int anio, int curso, int materia)
        {
            cursos cu = en.cursos.Where(c => c.id_comision == com && c.anio_calendario == anio && c.id_curso == curso && c.id_materia == materia).First();
            en.cursos.Remove(cu);
            en.SaveChanges();

        }
    }


}
