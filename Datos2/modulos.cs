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
    
    public partial class modulos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public modulos()
        {
            this.modulos_usuarios = new HashSet<modulos_usuarios>();
        }
    
        public int id_modulo { get; set; }
        public string desc_modulo { get; set; }
        public string ejecuta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modulos_usuarios> modulos_usuarios { get; set; }
    }
}
