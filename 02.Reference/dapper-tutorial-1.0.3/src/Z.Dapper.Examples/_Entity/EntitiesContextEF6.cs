using System.Collections.Generic;
using System.Data.Entity;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples
{
    public class EntitiesContextEF6 : DbContext
    {
        public EntitiesContextEF6() : base("Connection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>().ToTable("Invoice");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Invoice> Invoices { get; set; }

        public class Invoice
        {
            public int InvoiceID { get; set; }
            public string Code { get; set; }
            public InvoiceKind Kind { get; set; }
        }
    }
}