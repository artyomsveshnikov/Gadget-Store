using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                entity.HasKey(e => e.GadgetID)
                    .HasName("actors_pkey");

                entity.ToTable("Gadgets");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.Price)
                    .HasColumnName("price");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("character varying");
            });
        }

    }
}
