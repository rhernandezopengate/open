﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_A3F19C_OGEntities : DbContext
    {
        public DB_A3F19C_OGEntities()
            : base("name=DB_A3F19C_OGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<statusordenimpresa> statusordenimpresa { get; set; }
        public virtual DbSet<detordenproductoshd> detordenproductoshd { get; set; }
        public virtual DbSet<guias> guias { get; set; }
        public virtual DbSet<detusuariosordenes> detusuariosordenes { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
        public virtual DbSet<codigoqrordenes> codigoqrordenes { get; set; }
        public virtual DbSet<erroresordenes> erroresordenes { get; set; }
        public virtual DbSet<tipoerror> tipoerror { get; set; }
        public virtual DbSet<detkitskus> detkitskus { get; set; }
        public virtual DbSet<kit> kit { get; set; }
        public virtual DbSet<ordenes> ordenes { get; set; }
        public virtual DbSet<skus> skus { get; set; }
    }
}
