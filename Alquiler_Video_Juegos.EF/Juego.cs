//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alquiler_Video_Juegos.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Juego
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Juego()
        {
            this.Hitorials = new HashSet<Hitorial>();
        }
    
        public int id_Juego { get; set; }
        public string Nombre_Juego { get; set; }
        public string Descripcion_Juego { get; set; }
        public Nullable<int> Tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hitorial> Hitorials { get; set; }
    }
}
