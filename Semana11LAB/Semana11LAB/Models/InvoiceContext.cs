using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Semana11LAB.Models
{
    public class InvoiceContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Detail> Details { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-020QSCF; Database=Apisemana11; Integrated Security=True;Trust Server Certificate=True ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de clave primaria
            modelBuilder.Entity<Customer>().HasKey(c => c.IdCustomers);
            modelBuilder.Entity<Invoice>().HasKey(i => i.IdInvoices);
            modelBuilder.Entity<Product>().HasKey(p => p.IdProducts);
            modelBuilder.Entity<Detail>().HasKey(d => d.IdDetails);

            // Configuración de relaciones
            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Customer)
                .WithMany(c => c.Invoices) // Relación de uno a muchos
                .HasForeignKey(i => i.CustomerID);

            modelBuilder.Entity<Detail>()
                .HasOne(d => d.Product)
                .WithMany(p => p.Details) // Relación de uno a muchos
                .HasForeignKey(d => d.ProductID);

            modelBuilder.Entity<Detail>()
                .HasOne(d => d.Invoice)
                .WithMany(i => i.Details) // Relación de uno a muchos
                .HasForeignKey(d => d.InvoiceID);
        }
    }
}