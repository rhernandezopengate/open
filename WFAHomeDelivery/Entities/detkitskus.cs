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
    
    public partial class detkitskus
    {
        public int id { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public int Kit_Id { get; set; }
        public int Skus_Id { get; set; }
    
        public virtual kit kit { get; set; }
        public virtual skus skus { get; set; }
    }
}