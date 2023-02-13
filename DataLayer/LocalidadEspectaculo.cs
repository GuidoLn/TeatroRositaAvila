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

    public partial class LocalidadEspectaculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocalidadEspectaculo()
        {
            this.Compra = new HashSet<Compra>();
        }

        public long Id { get; set; }
        public int Precio { get; set; }
        public long LocalidadAsientoid { get; set; }
        public long Espectaculoid { get; set; }
        public long Sectorid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compra> Compra { get; set; }
        public virtual Espectaculo Espectaculo { get; set; }
        public virtual LocalidadAsiento LocalidadAsiento { get; set; }
        public virtual Sector Sector { get; set; }

        public long crearLocalidadEspectaculo(LocalidadEspectaculo localidadEspectaculo)
        {
            long resultado = 0;
            using (TeatroEntities db = new TeatroEntities())
            {
                db.LocalidadEspectaculo.Add(localidadEspectaculo);
                if (db.SaveChanges() == 1)
                {
                    resultado = localidadEspectaculo.Id;
                    return resultado;
                }
            }
            return resultado;
        }
    }
}
