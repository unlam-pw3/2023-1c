using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SistemaDeCadenasAlimenticias.Data.EF;

public partial class Pw320231cModelo2doParcialContext : DbContext
{
    public Pw320231cModelo2doParcialContext()
    {
    }

    public Pw320231cModelo2doParcialContext(DbContextOptions<Pw320231cModelo2doParcialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cadena> Cadenas { get; set; }

    public virtual DbSet<Sucursal> Sucursals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyDbConnection"));
        }
    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=.;Database=PW3-2023-1c-Modelo-2do-parcial;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cadena>(entity =>
        {
            entity.ToTable("Cadena");

            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .HasColumnName("Razon_social");
        });

        modelBuilder.Entity<Sucursal>(entity =>
        {
            entity.ToTable("Sucursal");

            entity.Property(e => e.Ciudad).HasMaxLength(50);
            entity.Property(e => e.Direccion).HasMaxLength(50);

            entity.HasOne(d => d.IdCadenaNavigation).WithMany(p => p.Sucursals)
                .HasForeignKey(d => d.IdCadena)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sucursal_Cadena");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
