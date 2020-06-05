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

                entity.Property(e => e.GadgetId)
                    .ValueGeneratedOnAdd();

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

            modelBuilder.Entity<Gadget>().HasData(
                new Gadget
                {
                    GadgetId = 1,
                    Name = "ProntoTec 7",
                    Description = "Android 4.4 KitKat Tablet PC, Cortex A8 1.2 GHz Dual Core Processor,512MB / 4GB,Dual Camera,G-Sensor (Black)",
                    Price = 46.99F,
                    Image = "prontotec.jpg"
                },
                new Gadget
                {
                    GadgetId = 2,
                    Name = "Samsung Galaxy",
                    Description = "Android 4.4 Kit Kat OS, 1.2 GHz quad-core processor",
                    Price = 120.95F,
                    Image = "samsung-galaxy.jpg"
                },
                new Gadget
                {
                    GadgetId = 3,
                    Name = "NeuTab® N7 Pro 7",
                    Description = "NeuTab N7 Pro tablet features the amazing powerful, Quad Core processor performs approximately Double multitasking running speed, and is more reliable than ever",
                    Price = 59.99F,
                    Image = "neutab.jpg"
                },
                new Gadget
                {
                    GadgetId = 4,
                    Name = "Dragon Touch® Y88X 7",
                    Description = "Dragon Touch Y88X tablet featuring the incredible powerful Allwinner Quad Core A33, up to four times faster CPU, ensures faster multitasking speed than ever. With the super-portable size, you get a robust power in a device that can be taken everywhere",
                    Price = 54.99F,
                    Image = "dragon-touch.jpg"
                },
                new Gadget
                {
                    GadgetId = 5,
                    Name = "Alldaymall A88X 7",
                    Description = "This Alldaymall tablet featuring the incredible powerful Allwinner Quad Core A33, up to four times faster CPU, ensures faster multitasking speed than ever. With the super-portable size, you get a robust power in a device that can be taken everywhere",
                    Price = 47.99F,
                    Image = "Alldaymall.jpg"
                },
                new Gadget
                {
                    GadgetId = 6,
                    Name = "ASUS MeMO",
                    Description = "Pad 7 ME170CX-A1-BK 7-Inch 16GB Tablet. Dual-Core Intel Atom Z2520 1.2GHz CPU",
                    Price = 94.99F,
                    Image = "asus-memo.jpg"
                },
                new Gadget
                {
                    GadgetId = 7,
                    Name = "ASUS 15.6-Inch",
                    Description = "Latest Generation Intel Dual Core Celeron 2.16 GHz Processor (turbo to 2.41 GHz)",
                    Price = 249.5F,
                    Image = "asus-latest.jpg"
                },
                new Gadget
                {
                    GadgetId = 8,
                    Name = "HP Pavilion 15-r030wm",
                    Description = "This Certified Refurbished product is manufacturer refurbished, shows limited or no wear, and includes all original accessories plus a 90-day warranty",
                    Price = 299.95F,
                    Image = "hp-pavilion.jpg"
                },
                new Gadget
                {
                    GadgetId = 9,
                    Name = "Dell Inspiron 15.6-Inch",
                    Description = "Intel Celeron N2830 Processor, 15.6-Inch Screen, Intel HD Graphics",
                    Price = 308.00F,
                    Image = "dell-inspiron.jpg"
                },
                new Gadget
                {
                    GadgetId = 10,
                    Name = "Acer Aspire E Notebook",
                    Description = "15.6 HD Active Matrix TFT Color LED (1366 x 768) 16:9 CineCrystal Display",
                    Price = 299.95F,
                    Image = "acer-aspire.jpg"
                },
                new Gadget
                {
                    GadgetId = 11,
                    Name = "HP Stream 13",
                    Description = "Intel Celeron N2840 Processor. 2 GB DDR3L SDRAM, 32 GB Solid-State Drive and 1TB OneDrive Cloud Storage for one year",
                    Price = 202.99F,
                    Image = "hp-stream.jpg"
                },
                new Gadget
                {
                    GadgetId = 12,
                    Name = "Nokia Lumia 521",
                    Description = "T-Mobile Cell Phone 4G - White. 5MP Camera - Snap creative photos with built-in digital lenses",
                    Price = 63.99F,
                    Image = "nokia-lumia.jpg"
                },
                new Gadget
                {
                    GadgetId = 13,
                    Name = "HTC Desire 816",
                    Description = "13 MP Rear Facing BSI Camera / 5 MP Front Facing",
                    Price = 177.99F,
                    Image = "htc-desire.jpg"
                },
                new Gadget
                {
                    GadgetId = 14,
                    Name = "Sanyo Innuendo",
                    Description = "Uniquely designed 3G-enabled messaging phone with side-flipping QWERTY keyboard and external glow-thru OLED dial pad that 'disappears' when not in use",
                    Price = 54.99F,
                    Image = "sanyo-innuendo.jpg"
                },
                new Gadget
                {
                    GadgetId = 15,
                    Name = "Ulefone N9000",
                    Description = "Unlocked world GSM phone. 3G-850/2100, 2G -850/900/1800/1900",
                    Price = 133.99F,
                    Image = "ulefone.jpg"
                }

                );

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
