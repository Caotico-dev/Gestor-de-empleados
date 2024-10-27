using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Gestion_de_empleados_.Models;

public partial class GestorEmpleadosContext : DbContext
{
    public GestorEmpleadosContext()
    {
    }

    public GestorEmpleadosContext(DbContextOptions<GestorEmpleadosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Proyecto> Proyectos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-2MA536R; Database=GestorEmpleados; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.DepartamentoId).HasName("PK__Departam__66BB0E3E4ACFCF6C");

            entity.ToTable("Departamento");

            entity.Property(e => e.DepartamentoId).ValueGeneratedNever();
            entity.Property(e => e.Funcion)
                .HasMaxLength(130)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(70)
                .IsUnicode(false);

            entity.HasOne(d => d.Empleado).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK__Departame__Emple__3B75D760");

            entity.HasOne(d => d.Proyecto).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.ProyectoId)
                .HasConstraintName("FK__Departame__Proye__3C69FB99");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.EmpleadoId).HasName("PK__Empleado__958BE9109752FC21");

            entity.Property(e => e.EmpleadoId).ValueGeneratedNever();
            entity.Property(e => e.Apellido)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaDeIngreso).HasColumnName("Fecha_de_ingreso");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property( e => e.Activo).HasMaxLength(2).IsUnicode(false);
            entity.Property(e => e.Sueldo).HasPrecision(18, 2).IsUnicode(false);        });

        modelBuilder.Entity<Proyecto>(entity =>
        {
            entity.HasKey(e => e.ProyectoId).HasName("PK__Proyecto__CF241D6506D61CFE");

            entity.Property(e => e.ProyectoId).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(240)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(70)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder); 
}
