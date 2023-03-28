﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Terminal.Entities.Entities;

#nullable disable

namespace Terminal.DataAccess.Context
{
    public partial class DbterminalContext : DbContext
    {
        public DbterminalContext()
        {
        }

        public DbterminalContext(DbContextOptions<DbterminalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<VW_graficaSexo> VW_graficaSexo { get; set; }
        public virtual DbSet<VW_graficaViaje> VW_graficaViaje { get; set; }
        public virtual DbSet<VW_tbBoletos> VW_tbBoletos { get; set; }
        public virtual DbSet<VW_tbCargos> VW_tbCargos { get; set; }
        public virtual DbSet<VW_tbClientes> VW_tbClientes { get; set; }
        public virtual DbSet<VW_tbHorarios> VW_tbHorarios { get; set; }
        public virtual DbSet<VW_tbTerminales> VW_tbTerminales { get; set; }
        public virtual DbSet<tbBoletos> tbBoletos { get; set; }
        public virtual DbSet<tbCargos> tbCargos { get; set; }
        public virtual DbSet<tbClientes> tbClientes { get; set; }
        public virtual DbSet<tbCompania> tbCompania { get; set; }
        public virtual DbSet<tbDepartamentos> tbDepartamentos { get; set; }
        public virtual DbSet<tbEmpleados> tbEmpleados { get; set; }
        public virtual DbSet<tbEstadosCiviles> tbEstadosCiviles { get; set; }
        public virtual DbSet<tbHorarios> tbHorarios { get; set; }
        public virtual DbSet<tbMetodosPago> tbMetodosPago { get; set; }
        public virtual DbSet<tbMunicipios> tbMunicipios { get; set; }
        public virtual DbSet<tbPantallas> tbPantallas { get; set; }
        public virtual DbSet<tbRoles> tbRoles { get; set; }
        public virtual DbSet<tbRolesXPantallas> tbRolesXPantallas { get; set; }
        public virtual DbSet<tbTerminales> tbTerminales { get; set; }
        public virtual DbSet<tbUsuarios> tbUsuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<VW_graficaSexo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_graficaSexo", "gral");
            });

            modelBuilder.Entity<VW_graficaViaje>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_graficaViaje", "gral");

                entity.Property(e => e.bole_hora_Destino_Nombre).HasMaxLength(200);
            });

            modelBuilder.Entity<VW_tbBoletos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_tbBoletos", "term");

                entity.Property(e => e.bole_Fecha).HasColumnType("datetime");

                entity.Property(e => e.bole_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.bole_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.bole_Precio).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.bole_UsuarioCreador_Nombre).HasMaxLength(100);

                entity.Property(e => e.bole_UsuarioModificador_Nombre).HasMaxLength(100);

                entity.Property(e => e.bole_clie_Nombre_Completo)
                    .IsRequired()
                    .HasMaxLength(401);

                entity.Property(e => e.bole_empl_Nombre_Completo)
                    .IsRequired()
                    .HasMaxLength(403);

                entity.Property(e => e.bole_hora_Destino_Nombre).HasMaxLength(200);

                entity.Property(e => e.bole_hora_Origen_Nombre).HasMaxLength(200);

                entity.Property(e => e.clie_Apellidos).HasMaxLength(200);

                entity.Property(e => e.clie_Nombres).HasMaxLength(200);

                entity.Property(e => e.clie_Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.comp_Direccion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.comp_Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.empl_PrimerApellido).HasMaxLength(100);

                entity.Property(e => e.empl_PrimerNombre).HasMaxLength(100);

                entity.Property(e => e.empl_SegundoApellido).HasMaxLength(100);

                entity.Property(e => e.empl_SegundoNombre).HasMaxLength(100);

                entity.Property(e => e.hora_Destino)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.hora_FechaLlegada).HasColumnType("datetime");

                entity.Property(e => e.hora_FechaSalida).HasColumnType("datetime");

                entity.Property(e => e.hora_Origen)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.pago_Descripcion).HasMaxLength(200);

                entity.Property(e => e.term_DireccionExacta)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.term_Nombre)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VW_tbCargos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_tbCargos", "term");

                entity.Property(e => e.carg_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.carg_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.carg_Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.carg_UsuarioCreador_Nombre).HasMaxLength(100);

                entity.Property(e => e.carg_UsuarioModificador_Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<VW_tbClientes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_tbClientes", "term");

                entity.Property(e => e.clie_Apellidos).HasMaxLength(200);

                entity.Property(e => e.clie_DNI)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.clie_Email).HasMaxLength(300);

                entity.Property(e => e.clie_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.clie_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.clie_NombreCompleto)
                    .IsRequired()
                    .HasMaxLength(401);

                entity.Property(e => e.clie_Nombres).HasMaxLength(200);

                entity.Property(e => e.clie_Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.clie_Telefono)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.clie_UsuarioCreador_Nombre).HasMaxLength(100);

                entity.Property(e => e.clie_UsuarioModificador_Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<VW_tbHorarios>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_tbHorarios", "term");

                entity.Property(e => e.hora_Destino)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.hora_Destino_DeptoNombre).HasMaxLength(200);

                entity.Property(e => e.hora_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.hora_FechaLlegada).HasColumnType("datetime");

                entity.Property(e => e.hora_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.hora_FechaSalida).HasColumnType("datetime");

                entity.Property(e => e.hora_Origen)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.hora_Origen_DeptoNombre).HasMaxLength(200);

                entity.Property(e => e.hora_UsuarioCreador_Nombre).HasMaxLength(100);

                entity.Property(e => e.hora_UsuarioModificador_Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<VW_tbTerminales>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_tbTerminales", "term");

                entity.Property(e => e.dept_Descripcion).HasMaxLength(200);

                entity.Property(e => e.dept_ID)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.muni_Descripcion).HasMaxLength(200);

                entity.Property(e => e.muni_ID)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.term_DireccionExacta)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.term_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.term_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.term_Nombre)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.term_UsuarioCreador_Nombre).HasMaxLength(100);

                entity.Property(e => e.term_UsuarioModificador_Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<tbBoletos>(entity =>
            {
                entity.HasKey(e => e.bole_ID)
                    .HasName("PK_term_tbBoletos_bole_ID");

                entity.ToTable("tbBoletos", "term");

                entity.Property(e => e.bole_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.bole_Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.bole_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.bole_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.bole_Precio).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.bole_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbBoletosbole_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.bole_UsuarioCreador)
                    .HasConstraintName("FK_term_tbBoletos_bole_UsuarioCreador_acce_tbUsuarios_usua_ID");

                entity.HasOne(d => d.bole_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbBoletosbole_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.bole_UsuarioModificador)
                    .HasConstraintName("FK_term_tbBoletos_bole_UsuarioModificador_acce_tbUsuarios_usua_ID");

                entity.HasOne(d => d.clie)
                    .WithMany(p => p.tbBoletos)
                    .HasForeignKey(d => d.clie_ID)
                    .HasConstraintName("FK_term_tbBoletos_tbClientes_clie_ID");

                entity.HasOne(d => d.comp)
                    .WithMany(p => p.tbBoletos)
                    .HasForeignKey(d => d.comp_ID)
                    .HasConstraintName("FK_term_tbBoletos_tbCompanias_comp_ID");

                entity.HasOne(d => d.empl)
                    .WithMany(p => p.tbBoletos)
                    .HasForeignKey(d => d.empl_ID)
                    .HasConstraintName("FK_term_tbBoletos_tbEmpleados_empl_ID");

                entity.HasOne(d => d.hora)
                    .WithMany(p => p.tbBoletos)
                    .HasForeignKey(d => d.hora_ID)
                    .HasConstraintName("FK_term_tbBoletos_tbHorarios_hora_ID");

                entity.HasOne(d => d.pago)
                    .WithMany(p => p.tbBoletos)
                    .HasForeignKey(d => d.pago_ID)
                    .HasConstraintName("FK_term_tbBoletos_gral_tbMetodosPago_pago_ID");

                entity.HasOne(d => d.term)
                    .WithMany(p => p.tbBoletos)
                    .HasForeignKey(d => d.term_ID)
                    .HasConstraintName("FK_term_tbBoletos_tbTerminales_term_ID");
            });

            modelBuilder.Entity<tbCargos>(entity =>
            {
                entity.HasKey(e => e.carg_ID)
                    .HasName("PK_term_tbCargos_carg_ID");

                entity.ToTable("tbCargos", "term");

                entity.Property(e => e.carg_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.carg_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.carg_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.carg_Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.carg_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbCargoscarg_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.carg_UsuarioCreador)
                    .HasConstraintName("FK_term_tbCargos_carg_UsuarioCreador_acce_tbUsuarios_usua_ID");

                entity.HasOne(d => d.carg_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbCargoscarg_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.carg_UsuarioModificador)
                    .HasConstraintName("FK_term_tbCargos_carg_UsuarioModificador_acce_tbUsuarios_usua_ID");
            });

            modelBuilder.Entity<tbClientes>(entity =>
            {
                entity.HasKey(e => e.clie_ID)
                    .HasName("PK_term_tbPasajeros_psjr_ID");

                entity.ToTable("tbClientes", "term");

                entity.HasIndex(e => e.clie_DNI, "UQ_term_tbPasajeros_psjr_DNI")
                    .IsUnique();

                entity.Property(e => e.clie_Apellidos).HasMaxLength(200);

                entity.Property(e => e.clie_DNI)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.clie_Email).HasMaxLength(300);

                entity.Property(e => e.clie_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.clie_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.clie_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.clie_Nombres).HasMaxLength(200);

                entity.Property(e => e.clie_Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.clie_Telefono)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.clie_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbClientesclie_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.clie_UsuarioCreador)
                    .HasConstraintName("FK_term_tbClientes_clie_UsuarioCreador_acce_tbUsuarios_usua_ID");

                entity.HasOne(d => d.clie_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbClientesclie_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.clie_UsuarioModificador)
                    .HasConstraintName("FK_term_tbClientes_clie_UsuarioModificador_acce_tbUsuarios_usua_ID");
            });

            modelBuilder.Entity<tbCompania>(entity =>
            {
                entity.HasKey(e => e.comp_ID)
                    .HasName("PK_term_tbCompania_comp_ID");

                entity.ToTable("tbCompania", "term");

                entity.Property(e => e.comp_Direccion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.comp_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.comp_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.comp_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.comp_Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.muni_ID)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.comp_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbCompaniacomp_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.comp_UsuarioCreador)
                    .HasConstraintName("FK_term_tbCompania_comp_UsuarioCreador_acce_tbUsuarios_usua_ID");

                entity.HasOne(d => d.comp_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbCompaniacomp_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.comp_UsuarioModificador)
                    .HasConstraintName("FK_term_tbCompania_comp_UsuarioModificador_acce_tbUsuarios_usua_ID");
            });

            modelBuilder.Entity<tbDepartamentos>(entity =>
            {
                entity.HasKey(e => e.dept_ID)
                    .HasName("PK_gral_tbDepartamentos_dept_ID");

                entity.ToTable("tbDepartamentos", "gral");

                entity.Property(e => e.dept_ID)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.dept_Descripcion).HasMaxLength(200);

                entity.Property(e => e.dept_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.dept_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.dept_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.dept_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbDepartamentosdept_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.dept_UsuarioCreador)
                    .HasConstraintName("FK_gral_tbDepartamentos_dept_UsuarioCreador_acce_tbUsuarios_usua_ID");

                entity.HasOne(d => d.dept_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbDepartamentosdept_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.dept_UsuarioModificador)
                    .HasConstraintName("FK_gral_tbDepartamentos_dept_UsuarioModificador_acce_tbUsuarios_usua_ID");
            });

            modelBuilder.Entity<tbEmpleados>(entity =>
            {
                entity.HasKey(e => e.empl_ID)
                    .HasName("PK_term_tbEmpleados_empl_ID");

                entity.ToTable("tbEmpleados", "term");

                entity.HasIndex(e => e.empl_DNI, "UQ_term_tbEmpleados_empl_DNI")
                    .IsUnique();

                entity.Property(e => e.empl_DNI)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.empl_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.empl_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.empl_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.empl_FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.empl_PrimerApellido).HasMaxLength(100);

                entity.Property(e => e.empl_PrimerNombre).HasMaxLength(100);

                entity.Property(e => e.empl_SegundoApellido).HasMaxLength(100);

                entity.Property(e => e.empl_SegundoNombre).HasMaxLength(100);

                entity.Property(e => e.empl_Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.empl_Telefono)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.muni_ID)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.carg)
                    .WithMany(p => p.tbEmpleados)
                    .HasForeignKey(d => d.carg_ID)
                    .HasConstraintName("FK_term_tbEmpleados_tbCargos_carg_ID");

                entity.HasOne(d => d.empl_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbEmpleadosempl_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.empl_UsuarioCreador)
                    .HasConstraintName("FK_term_tbEmpleados_empl_UsuarioCreador_acce_tbUsuarios_usua_ID");

                entity.HasOne(d => d.empl_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbEmpleadosempl_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.empl_UsuarioModificador)
                    .HasConstraintName("FK_term_tbEmpleados_empl_UsuarioModificador_acce_tbUsuarios_usua_ID");

                entity.HasOne(d => d.estciv)
                    .WithMany(p => p.tbEmpleados)
                    .HasForeignKey(d => d.estciv_ID)
                    .HasConstraintName("FK_term_tbEmpleados_gral_tbEstadosCiviles_estciv_ID");

                entity.HasOne(d => d.muni)
                    .WithMany(p => p.tbEmpleados)
                    .HasForeignKey(d => d.muni_ID)
                    .HasConstraintName("FK_term_tbEmpleados_gral_tbMunicipios_muni_ID");
            });

            modelBuilder.Entity<tbEstadosCiviles>(entity =>
            {
                entity.HasKey(e => e.estciv_ID)
                    .HasName("PK_gral_tbEstadosCiviles_estciv_ID");

                entity.ToTable("tbEstadosCiviles", "gral");

                entity.Property(e => e.estciv_Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.estciv_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.estciv_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.estciv_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.estciv_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbEstadosCivilesestciv_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.estciv_UsuarioCreador)
                    .HasConstraintName("FK_gral_tbEstadosCiviles_estciv_UsuarioCreador_acce_tbUsuarios_usua_ID");

                entity.HasOne(d => d.estciv_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbEstadosCivilesestciv_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.estciv_UsuarioModificador)
                    .HasConstraintName("FK_gral_tbEstadosCiviles_estciv_UsuarioModificador_acce_tbUsuarios_usua_ID");
            });

            modelBuilder.Entity<tbHorarios>(entity =>
            {
                entity.HasKey(e => e.hora_ID)
                    .HasName("PK_term_tbHorarios_hora_ID");

                entity.ToTable("tbHorarios", "term");

                entity.Property(e => e.hora_Destino)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.hora_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.hora_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.hora_FechaLlegada).HasColumnType("datetime");

                entity.Property(e => e.hora_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.hora_FechaSalida).HasColumnType("datetime");

                entity.Property(e => e.hora_Origen)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.hora_DestinoNavigation)
                    .WithMany(p => p.tbHorarioshora_DestinoNavigation)
                    .HasForeignKey(d => d.hora_Destino)
                    .HasConstraintName("FK_term_tbHorarios_hora_Destino_gral_tbDepartamentos_dept_ID");

                entity.HasOne(d => d.hora_OrigenNavigation)
                    .WithMany(p => p.tbHorarioshora_OrigenNavigation)
                    .HasForeignKey(d => d.hora_Origen)
                    .HasConstraintName("FK_term_tbHorarios_hora_Origen_gral_tbDepartamentos_dept_ID");

                entity.HasOne(d => d.hora_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbHorarioshora_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.hora_UsuarioCreador)
                    .HasConstraintName("FK_term_tbHorarios_hora_UsuarioCreador_acce_tbUsuarios_usua_ID");

                entity.HasOne(d => d.hora_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbHorarioshora_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.hora_UsuarioModificador)
                    .HasConstraintName("FK_term_tbHorarios_hora_UsuarioModificador_acce_tbUsuarios_usua_ID");
            });

            modelBuilder.Entity<tbMetodosPago>(entity =>
            {
                entity.HasKey(e => e.pago_ID)
                    .HasName("PK_gral_tbMetodosPago_pago_ID");

                entity.ToTable("tbMetodosPago", "gral");

                entity.Property(e => e.pago_Descripcion).HasMaxLength(200);

                entity.Property(e => e.pago_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.pago_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.pago_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.pago_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbMetodosPagopago_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.pago_UsuarioCreador)
                    .HasConstraintName("FK_gral_tbMetodosPago_pago_UsuarioCreador_acce_tbUsuarios_usua_ID");

                entity.HasOne(d => d.pago_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbMetodosPagopago_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.pago_UsuarioModificador)
                    .HasConstraintName("FK_gral_tbMetodosPago_pago_UsuarioModificador_acce_tbUsuarios_usua_ID");
            });

            modelBuilder.Entity<tbMunicipios>(entity =>
            {
                entity.HasKey(e => e.muni_ID)
                    .HasName("PK_gral_tbMunicipios_muni_ID");

                entity.ToTable("tbMunicipios", "gral");

                entity.Property(e => e.muni_ID)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.dept_ID)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.muni_Descripcion).HasMaxLength(200);

                entity.Property(e => e.muni_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.muni_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.muni_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.dept)
                    .WithMany(p => p.tbMunicipios)
                    .HasForeignKey(d => d.dept_ID)
                    .HasConstraintName("FK_gral_tbMunicipios_tbDepartamentos_dept_ID");

                entity.HasOne(d => d.muni_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbMunicipiosmuni_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.muni_UsuarioCreador)
                    .HasConstraintName("FK_gral_tbMunicipios_muni_UsuarioCreador_acce_tbUsuarios_usua_ID");

                entity.HasOne(d => d.muni_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbMunicipiosmuni_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.muni_UsuarioModificador)
                    .HasConstraintName("FK_gral_tbMunicipios_muni_UsuarioModificador_acce_tbUsuarios_usua_ID");
            });

            modelBuilder.Entity<tbPantallas>(entity =>
            {
                entity.HasKey(e => e.pant_ID)
                    .HasName("PK_acce_tbPantallas_pant_ID");

                entity.ToTable("tbPantallas", "acce");

                entity.Property(e => e.pant_Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.pant_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.pant_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.pant_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.pant_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbPantallaspant_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.pant_UsuarioCreador)
                    .HasConstraintName("FK_acce_tbPantallas_pant_UsuarioCreador_tbUsuarios_usua_ID");

                entity.HasOne(d => d.pant_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbPantallaspant_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.pant_UsuarioModificador)
                    .HasConstraintName("FK_acce_tbPantallas_pant_UsuarioModificador_tbUsuarios_usua_ID");
            });

            modelBuilder.Entity<tbRoles>(entity =>
            {
                entity.HasKey(e => e.role_ID)
                    .HasName("PK_acce_tbRoles_role_ID");

                entity.ToTable("tbRoles", "acce");

                entity.Property(e => e.role_Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.role_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.role_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.role_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.role_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbRolesrole_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.role_UsuarioCreador)
                    .HasConstraintName("FK_acce_tbRoles_role_UsuarioCreador_tbUsuarios_usua_ID");

                entity.HasOne(d => d.role_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbRolesrole_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.role_UsuarioModificador)
                    .HasConstraintName("FK_acce_tbRoles_role_UsuarioModificador_tbUsuarios_usua_ID");
            });

            modelBuilder.Entity<tbRolesXPantallas>(entity =>
            {
                entity.HasKey(e => e.roleXpant_ID)
                    .HasName("PK_acce_tbRolesXPantallas_roleXpant_ID");

                entity.ToTable("tbRolesXPantallas", "acce");

                entity.Property(e => e.roleXpant_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.roleXpant_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.roleXpant_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.pant)
                    .WithMany(p => p.tbRolesXPantallas)
                    .HasForeignKey(d => d.pant_ID)
                    .HasConstraintName("FK_acce_tbRolesXPantallas_tbPantallas_pant_ID");

                entity.HasOne(d => d.roleXpant_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbRolesXPantallasroleXpant_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.roleXpant_UsuarioCreador)
                    .HasConstraintName("FK_acce_tbRolesXPantallas_roleXpant_UsuarioCreador_tbUsuarios_usua_ID");

                entity.HasOne(d => d.roleXpant_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbRolesXPantallasroleXpant_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.roleXpant_UsuarioModificador)
                    .HasConstraintName("FK_acce_tbRolesXPantallas_roleXpant_UsuarioModificador_tbUsuarios_usua_ID");

                entity.HasOne(d => d.role)
                    .WithMany(p => p.tbRolesXPantallas)
                    .HasForeignKey(d => d.role_ID)
                    .HasConstraintName("FK_acce_tbRolesXPantallas_tbRoles_role_ID");

                entity.HasOne(d => d.usua)
                    .WithMany(p => p.tbRolesXPantallasusua)
                    .HasForeignKey(d => d.usua_ID)
                    .HasConstraintName("FK_acce_tbRolesXPantallas_tbUsuarios_usua_ID");
            });

            modelBuilder.Entity<tbTerminales>(entity =>
            {
                entity.HasKey(e => e.term_ID)
                    .HasName("PK_term_tbTerminales_term_ID");

                entity.ToTable("tbTerminales", "term");

                entity.Property(e => e.muni_ID)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.term_DireccionExacta)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.term_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.term_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.term_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.term_Nombre)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.muni)
                    .WithMany(p => p.tbTerminales)
                    .HasForeignKey(d => d.muni_ID)
                    .HasConstraintName("FK_term_tbTerminales_gral_tbMunicipios_muni_ID");

                entity.HasOne(d => d.term_UsuarioCreadorNavigation)
                    .WithMany(p => p.tbTerminalesterm_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.term_UsuarioCreador)
                    .HasConstraintName("FK_term_tbTerminales_term_UsuarioCreador_acce_tbUsuarios_usua_ID");

                entity.HasOne(d => d.term_UsuarioModificadorNavigation)
                    .WithMany(p => p.tbTerminalesterm_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.term_UsuarioModificador)
                    .HasConstraintName("FK_term_tbTerminales_term_UsuarioModificador_acce_tbUsuarios_usua_ID");
            });

            modelBuilder.Entity<tbUsuarios>(entity =>
            {
                entity.HasKey(e => e.usua_ID)
                    .HasName("PK_acce_tbUsuarios_usua_ID");

                entity.ToTable("tbUsuarios", "acce");

                entity.HasIndex(e => e.usua_Usuario, "UQ_acce_tbUsuarios_usua_Usuario")
                    .IsUnique();

                entity.Property(e => e.usua_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.usua_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.usua_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.usua_Usuario).HasMaxLength(100);

                entity.HasOne(d => d.empl)
                    .WithMany(p => p.tbUsuarios)
                    .HasForeignKey(d => d.empl_ID)
                    .HasConstraintName("FK_acce_tbUsuarios_term_tbEmpleados_empl_ID");

                entity.HasOne(d => d.usua_UsuarioCreadorNavigation)
                    .WithMany(p => p.Inverseusua_UsuarioCreadorNavigation)
                    .HasForeignKey(d => d.usua_UsuarioCreador)
                    .HasConstraintName("FK_acce_tbUsuarios_usua_UsuarioCreador_tbUsuarios_usua_ID");

                entity.HasOne(d => d.usua_UsuarioModificadorNavigation)
                    .WithMany(p => p.Inverseusua_UsuarioModificadorNavigation)
                    .HasForeignKey(d => d.usua_UsuarioModificador)
                    .HasConstraintName("FK_acce_tbUsuarios_usua_UsuarioModificador_tbUsuarios_usua_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}