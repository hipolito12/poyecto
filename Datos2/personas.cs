//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos2
{
    using System;
    using System.Collections.Generic;
    
    public partial class personas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public personas()
        {
            this.alumnos_inscripciones = new HashSet<alumnos_inscripciones>();
            this.docentes_cursos = new HashSet<docentes_cursos>();
            this.usuarios = new HashSet<usuarios>();
        }
    
        public int id_persona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public System.DateTime fecha_nac { get; set; }
        public Nullable<int> legajo { get; set; }
        public int tipo_persona { get; set; }
        public int id_plan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alumnos_inscripciones> alumnos_inscripciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<docentes_cursos> docentes_cursos { get; set; }
        public virtual planes planes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuarios> usuarios { get; set; }
    }
}
