//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinal.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Espectaculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Espectaculo()
        {
            this.Compra = new HashSet<Compra>();
            this.LocalidadEspectaculo = new HashSet<LocalidadEspectaculo>();
        }
    
        public long Id { get; set; }
        public string NombreEspectaculo { get; set; }
        public string DescripcionEspectaculo { get; set; }
        public Nullable<System.DateTime> FechaYHora { get; set; }
        public bool EstadoEspectaculo { get; set; }
        public Nullable<int> PrecioEspectaculo { get; set; }
        public long Companiaid { get; set; }
    
        public virtual Compania Compania { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compra> Compra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocalidadEspectaculo> LocalidadEspectaculo { get; set; }
    }
}
