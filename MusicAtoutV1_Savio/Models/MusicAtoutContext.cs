using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MusicAtoutV1_Savio.Models;

public partial class MusicAtoutContext : DbContext
{
    public MusicAtoutContext()
    {
    }

    public MusicAtoutContext(DbContextOptions<MusicAtoutContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Batiment> Batiments { get; set; }

    public virtual DbSet<Salle> Salles { get; set; }

    public virtual DbSet<Typeoeuvre> Typeoeuvres { get; set; }

    public virtual DbSet<Ville> Villes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-6542KO35;Initial Catalog=MusicAtout_LSAVIO;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Batiment>(entity =>
        {
            entity.HasKey(e => e.IdBati);

            entity.ToTable("BATIMENT");

            entity.Property(e => e.IdBati).HasColumnName("idBati");
            entity.Property(e => e.AnConstruction).HasColumnName("anConstruction");
            entity.Property(e => e.CpBati).HasColumnName("cpBati");
            entity.Property(e => e.IdVille).HasColumnName("idVille");
            entity.Property(e => e.NomBati)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nomBati");
            entity.Property(e => e.Responsable)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsable");
            entity.Property(e => e.RueBati)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("rueBati");
            entity.Property(e => e.TelBati)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telBati");

            entity.HasOne(d => d.IdVilleNavigation).WithMany(p => p.Batiments)
                .HasForeignKey(d => d.IdVille)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BATIMENT_VILLE");
        });

        modelBuilder.Entity<Salle>(entity =>
        {
            entity.HasKey(e => new { e.IdBati, e.NumSalle });

            entity.ToTable("SALLE");

            entity.Property(e => e.IdBati).HasColumnName("idBati");
            entity.Property(e => e.NumSalle).HasColumnName("numSalle");
            entity.Property(e => e.Capacite).HasColumnName("capacite");
            entity.Property(e => e.NomSalle)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nomSalle");
            entity.Property(e => e.Superficie).HasColumnName("superficie");

            entity.HasOne(d => d.IdBatiNavigation).WithMany(p => p.Salles)
                .HasForeignKey(d => d.IdBati)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SALLE_BATIMENT");

            entity.HasMany(d => d.IdTypes).WithMany(p => p.Salles)
                .UsingEntity<Dictionary<string, object>>(
                    "Accueillir",
                    r => r.HasOne<Typeoeuvre>().WithMany()
                        .HasForeignKey("IdType")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TYPEOEUVRE"),
                    l => l.HasOne<Salle>().WithMany()
                        .HasForeignKey("IdBati", "NumSalle")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SALLE"),
                    j =>
                    {
                        j.HasKey("IdBati", "NumSalle", "IdType");
                        j.ToTable("ACCUEILLIR");
                        j.IndexerProperty<int>("IdBati").HasColumnName("idBati");
                        j.IndexerProperty<int>("NumSalle").HasColumnName("numSalle");
                        j.IndexerProperty<int>("IdType").HasColumnName("idType");
                    });
        });

        modelBuilder.Entity<Typeoeuvre>(entity =>
        {
            entity.HasKey(e => e.IdType).HasName("PK_TYPE");

            entity.ToTable("TYPEOEUVRE");

            entity.Property(e => e.IdType).HasColumnName("idType");
            entity.Property(e => e.LibelleType)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("libelleType");
        });

        modelBuilder.Entity<Ville>(entity =>
        {
            entity.HasKey(e => e.IdVille);

            entity.ToTable("VILLE");

            entity.Property(e => e.IdVille).HasColumnName("idVille");
            entity.Property(e => e.Departement).HasColumnName("departement");
            entity.Property(e => e.NomVille)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nomVille");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
