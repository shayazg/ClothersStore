﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Papamamaya
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class stEntities3 : DbContext
    {
        private static stEntities3 context;

       

        public stEntities3()
            : base("name=stEntities3")
        {
        }

        public static stEntities3 GetContext()
        {
            if (context == null)
                context = new stEntities3();
            return context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tovari> tovari { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<zakaz> zakaz { get; set; }
    }
}