using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SmartphoneShop.Models;

namespace SmartphoneShop.Data
{
    public class GadgetStoreContext : DbContext
    {
        public GadgetStoreContext()
        {
        }

        public GadgetStoreContext(DbContextOptions<GadgetStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Gadget> Gadgets { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(configuration.GetConnectionString("RentalsConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gadget>(entity =>
            {
                entity.HasKey(e => e.GadgetId)
                    .HasName("Gadget_pkey");

                entity.ToTable("Gadgets");

                entity.Property(e => e.Name)
                    .HasColumnName("Name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Description)
                    .HasColumnName("Description")
                    .HasColumnType("character varying");

                entity.Property(e => e.Price)
                    .HasColumnName("Price");

                entity.Property(e => e.Image)
                    .HasColumnName("Image")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("order_pkey");

                entity.ToTable("Orders");

                entity.Property(e => e.GadgetId)
                    .HasColumnName("GadgetId");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserId")
                    .HasColumnType("text");
            });
        }

    }
}
