namespace SeedConnection.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SeedConnection.Models;

    public partial class DbConnection : DbContext
    {
        public DbConnection()
            : base("name=DbConnection")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Type)
                .IsUnicode(false);
        }
    }
}
