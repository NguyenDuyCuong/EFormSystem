using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples
{
    public class EntitiesContextEFCore : Microsoft.EntityFrameworkCore.DbContext
    {
        public EntitiesContextEFCore()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(My.ConnectionFactory());

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>().ToTable("Invoice");

            base.OnModelCreating(modelBuilder);
        }

        public Microsoft.EntityFrameworkCore.DbSet<Invoice> Invoices { get; set; }

        public class Invoice
        {
            public int InvoiceID { get; set; }
            public string Code { get; set; }
            public InvoiceKind Kind { get; set; }
        }
    }
}