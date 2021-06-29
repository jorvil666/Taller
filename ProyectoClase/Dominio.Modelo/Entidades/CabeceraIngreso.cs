//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio.Modelo.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class CabeceraIngreso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CabeceraIngreso()
        {
            this.DetalleIngreso = new HashSet<DetalleIngreso>();
        }
    
        public int idCabecera { get; set; }
        public Nullable<System.DateTime> fechaIngreso { get; set; }
        public string observacion { get; set; }
        public int idVehiculo { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual Vehiculo Vehiculo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleIngreso> DetalleIngreso { get; set; }
    }
}