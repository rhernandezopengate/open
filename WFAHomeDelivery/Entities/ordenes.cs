//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFAHomeDelivery.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ordenes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ordenes()
        {
            this.detordenproductoshd = new HashSet<detordenproductoshd>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public string Orden { get; set; }
        public Nullable<System.DateTime> TxnDate { get; set; }
        public string TxnNumber { get; set; }
        public string User { get; set; }
        public int StatusOrdenImpresa_Id { get; set; }
        public string Picker { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detordenproductoshd> detordenproductoshd { get; set; }
        public virtual statusordenimpresa statusordenimpresa { get; set; }
    }
}
