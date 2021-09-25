using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos2
{
    public class tets
    {

            

        public void testtt()
        {
            Entidades dbe = new Entidades();
            cursos kimi = new cursos();
            int num = 31;
            int cpo = 55;
            int com = 1;
            int mat = 1;
            kimi.anio_calendario = num;
            kimi.cupo = cpo;
            kimi.id_comision = com;
            kimi.id_materia = mat;
            dbe.cursos.Add(kimi);
            dbe.SaveChanges();
        }

        public void act() 
        {
            Entidades en = new Entidades();
            personas per = new personas();
            per = en.personas.Find(8);
            per.nombre =" DDDDD2";
            per.apellido = "AAA2";
            per.direccion = "DI2";
            per.email = "MAIL2";
            per.telefono = "44";
            per.fecha_nac = DateTime.Parse("16/2/2021");
            per.id_plan = 15;
            per.legajo = 11;
            per.tipo_persona = 1;
            // en.Entry(per).State = System.Data.Entity.EntityState.Modified;
            en.personas.Add(per);
            en.SaveChanges();
        }



    }
}
