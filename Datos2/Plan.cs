using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos2
{
   public class Plan
    {
        Entidades en = new Entidades();
        planes pl = new planes();
        public void ADDplan(string  desc, int espe)
        {
            pl.desc_plan = desc;
            pl.id_especialidad = espe;
            en.planes.Add(pl);
            en.SaveChanges();
        }
    
    
        public void editplan(string desc, int espe, int id) 
        {
            planes pl = en.planes.Where(plan=> plan.id_plan == id ).First();
            pl.id_especialidad = espe;
            pl.desc_plan = desc;
            pl.id_plan = id;
            en.Entry(pl).State = System.Data.Entity.EntityState.Modified;
            en.SaveChanges();

        }

        public void deletePlan(int id) 
        {
            planes pl = en.planes.Where(plan => plan.id_plan == id).First();
            en.planes.Remove(pl);
            en.SaveChanges();
        }
    
    }



}
