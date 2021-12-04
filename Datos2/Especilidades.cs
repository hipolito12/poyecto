using System.Data;
using System.Linq;
namespace Datos2
{
    public class Especilidades
    {
        Entidades en = new Entidades();
        especialidades es = new especialidades();

        public void agregarespecialidades(string descripcion)
        {
            es.desc_especialidad = descripcion;
            en.especialidades.Add(es);
            en.SaveChanges();
        }
        public void editarespecilidades(int id, string decrip)
        {
            especialidades espe = en.especialidades.Where(e => e.id_especialidad == id).First();
            espe.desc_especialidad = decrip;
            en.Entry(espe).State = System.Data.Entity.EntityState.Modified;
            en.SaveChanges();
        }
        public void eliminarespecilidad(int id)
        {
            especialidades espe = en.especialidades.Where(e => e.id_especialidad == id).First();
            en.especialidades.Remove(espe);
            en.SaveChanges();

        }
    }
}
