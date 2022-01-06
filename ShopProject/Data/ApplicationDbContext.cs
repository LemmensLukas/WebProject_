using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Training> Trainingen { get; set; }

        public DbSet<LeeftijdCategorie> LeeftijdCategoriën { get; set; }

        public DbSet<Product> Producten { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Orderlijn> Orderlijnen { get; set; }

        public DbSet<Categorie> Categories { get; set; }

        public DbSet<ProductCategorie> ProductCategorieën { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Training>().ToTable("Training");
            modelBuilder.Entity<LeeftijdCategorie>().ToTable("LeeftijdCategorie");
            modelBuilder.Entity<Product>().ToTable("Product").Property(p => p.Prijs).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Klant>().ToTable("Klant");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Orderlijn>().ToTable("Orderlijn").Property(p => p.TotaalPrijs).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Categorie>().ToTable("Categorie");
            modelBuilder.Entity<ProductCategorie>().ToTable("ProductCategorie");
        }
    }
}
