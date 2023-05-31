using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Clase7.EF.IslaDelTesoro.Data.Entidades
{
    public partial class PW320231CEFIslaDelTesoroContext : DbContext
    {
        public PW320231CEFIslaDelTesoroContext()
        {
        }

        public PW320231CEFIslaDelTesoroContext(DbContextOptions<PW320231CEFIslaDelTesoroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tesoro> Tesoros { get; set; } = null!;
        public virtual DbSet<Ubicacion> Ubicacions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8SMFKT9\\SQLEXPRESS;Database=PW3-2023-1C-EF-IslaDelTesoro;User Id=sa;Password=1234;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tesoro>(entity =>
            {
                entity.ToTable("Tesoro");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImagenUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Ubicacion>(entity =>
            {
                entity.ToTable("Ubicacion");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
