using System;
using System.Collections.Generic;
using Demo123.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo123.Context;

public partial class User11049Context : DbContext
{
    public User11049Context()
    {
    }

    public User11049Context(DbContextOptions<User11049Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employe> Employes { get; set; }

    public virtual DbSet<Solouser> Solousers { get; set; }

    public virtual DbSet<Teamuser> Teamusers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=192.168.7.159:5432; Database=user11049; Username=user11049; Password=77449");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepId).HasName("departments_pk");

            entity.ToTable("departments");

            entity.Property(e => e.DepId)
                .ValueGeneratedNever()
                .HasColumnName("dep_id");
            entity.Property(e => e.DepName)
                .HasColumnType("character varying")
                .HasColumnName("dep_name");
        });

        modelBuilder.Entity<Employe>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("employe_pk");

            entity.ToTable("employe");

            entity.Property(e => e.EmpId)
                .ValueGeneratedNever()
                .HasColumnName("emp_id");
            entity.Property(e => e.Department).HasColumnName("department");
            entity.Property(e => e.EmpName)
                .HasColumnType("character varying")
                .HasColumnName("emp_name");
            entity.Property(e => e.EmpPatronymic)
                .HasColumnType("character varying")
                .HasColumnName("emp_patronymic");
            entity.Property(e => e.EmpSurname)
                .HasColumnType("character varying")
                .HasColumnName("emp_surname");

            entity.HasOne(d => d.DepartmentNavigation).WithMany(p => p.Employes)
                .HasForeignKey(d => d.Department)
                .HasConstraintName("employe_departments_fk");
        });

        modelBuilder.Entity<Solouser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("solouser_pk");

            entity.ToTable("solouser");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ApplicationFinish).HasColumnName("application_finish");
            entity.Property(e => e.ApplicationStart).HasColumnName("application_start");
            entity.Property(e => e.EmployeId).HasColumnName("employe_id");
            entity.Property(e => e.IdDepartment).HasColumnName("id_department");
            entity.Property(e => e.PassportScreen)
                .HasColumnType("character varying")
                .HasColumnName("passport_screen");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Employe).WithMany(p => p.Solousers)
                .HasForeignKey(d => d.EmployeId)
                .HasConstraintName("solouser_employe_fk");

            entity.HasOne(d => d.IdDepartmentNavigation).WithMany(p => p.Solousers)
                .HasForeignKey(d => d.IdDepartment)
                .HasConstraintName("solouser_departments_fk");

            entity.HasOne(d => d.User).WithMany(p => p.Solousers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("solouser_users_fk");
        });

        modelBuilder.Entity<Teamuser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("teamuser");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pk");

            entity.ToTable("users");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Login)
                .HasColumnType("character varying")
                .HasColumnName("login");
            entity.Property(e => e.Organization)
                .HasColumnType("character varying")
                .HasColumnName("organization");
            entity.Property(e => e.PassNumber)
                .HasColumnType("character varying")
                .HasColumnName("pass_number");
            entity.Property(e => e.PassSeries)
                .HasColumnType("character varying")
                .HasColumnName("pass_series");
            entity.Property(e => e.Password)
                .HasColumnType("character varying")
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber)
                .HasColumnType("character varying")
                .HasColumnName("phone_number");
            entity.Property(e => e.UserImage)
                .HasColumnType("character varying")
                .HasColumnName("user_image");
            entity.Property(e => e.UserName)
                .HasColumnType("character varying")
                .HasColumnName("user_name");
            entity.Property(e => e.UserPatronymic)
                .HasColumnType("character varying")
                .HasColumnName("user_patronymic");
            entity.Property(e => e.UserSurname)
                .HasColumnType("character varying")
                .HasColumnName("user_surname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
