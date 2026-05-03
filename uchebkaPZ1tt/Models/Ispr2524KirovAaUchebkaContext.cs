using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace uchebkaPZ1tt.Models;

public partial class Ispr2524LinkovNIUchebkaContext : DbContext
{
    public Ispr2524LinkovNIUchebkaContext()
    {
    }

    public Ispr2524LinkovNIUchebkaContext(DbContextOptions<Ispr2524LinkovNIUchebkaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<InputDataComment> InputDataComments { get; set; }

    public virtual DbSet<InputDataRequest> InputDataRequests { get; set; }

    public virtual DbSet<InputDataUser> InputDataUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=cfif31.ru;database=ISPr25-24_KirovAA_uchebka;user=ISPr25-24_KirovAA;password=ISPr25-24_KirovAA;CharSet=utf8;", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.45-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<InputDataComment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PRIMARY");

            entity.ToTable("inputDataComments");

            entity.HasIndex(e => e.RequestId, "FK_MIDD_idx");

            entity.HasIndex(e => e.MasterId, "FK_MID_idx");

            entity.Property(e => e.CommentId).HasColumnName("commentID");
            entity.Property(e => e.MasterId).HasColumnName("masterID");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.RequestId).HasColumnName("requestID");

            entity.HasOne(d => d.Master).WithMany(p => p.InputDataComments)
                .HasForeignKey(d => d.MasterId)
                .HasConstraintName("FK_MID");

            entity.HasOne(d => d.Request).WithMany(p => p.InputDataComments)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK_RID");
        });

        modelBuilder.Entity<InputDataRequest>(entity =>
        {
            entity.HasKey(e => e.RequestId).HasName("PRIMARY");

            entity.ToTable("inputDataRequests");

            entity.HasIndex(e => e.ClientId, "FK_KID_idx");

            entity.HasIndex(e => e.MasterId, "FK_MIDD_idx");

            entity.Property(e => e.RequestId)
                .ValueGeneratedNever()
                .HasColumnName("requestID");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.CompletionDate)
                .HasColumnType("text")
                .HasColumnName("completionDate");
            entity.Property(e => e.ComputerTechModel)
                .HasColumnType("text")
                .HasColumnName("computerTechModel");
            entity.Property(e => e.ComputerTechType)
                .HasColumnType("text")
                .HasColumnName("computerTechType");
            entity.Property(e => e.MasterId).HasColumnName("masterID");
            entity.Property(e => e.ProblemDescryption)
                .HasColumnType("text")
                .HasColumnName("problemDescryption");
            entity.Property(e => e.RepairParts)
                .HasColumnType("text")
                .HasColumnName("repairParts");
            entity.Property(e => e.RequestStatus)
                .HasColumnType("text")
                .HasColumnName("requestStatus");
            entity.Property(e => e.StartDate)
                .HasColumnType("text")
                .HasColumnName("startDate");

            entity.HasOne(d => d.Client).WithMany(p => p.InputDataRequestClients)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KID");

            entity.HasOne(d => d.Master).WithMany(p => p.InputDataRequestMasters)
                .HasForeignKey(d => d.MasterId)
                .HasConstraintName("FK_MIDD");
        });

        modelBuilder.Entity<InputDataUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("inputDataUsers");

            entity.HasIndex(e => e.Phone, "phone_UNIQUE").IsUnique();

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("userID");
            entity.Property(e => e.Fio)
                .HasColumnType("text")
                .HasColumnName("fio");
            entity.Property(e => e.Login)
                .HasColumnType("text")
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasColumnType("text")
                .HasColumnName("password");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Type)
                .HasColumnType("text")
                .HasColumnName("type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
