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
    
    public partial class DetalleIngreso
    {
        public int idDetalle { get; set; }
        public Nullable<int> idIngreso { get; set; }
        public Nullable<int> cantidad { get; set; }
        public string observacion { get; set; }
        public int idServicios { get; set; }
           
    }
}
