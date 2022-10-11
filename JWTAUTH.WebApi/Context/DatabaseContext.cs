﻿using JWTAUTH.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTAUTH.WebApi.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<UserInfo> UserInfos { get; set; } = null!;

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("server=10.25.1.172;database=JWTAuthentication;user id=testUser;Password=whasaasahw;");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.EmployeeName).HasMaxLength(100);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.LoginId)
                    .HasMaxLength(256)
                    .HasColumnName("LoginID");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NationalIdnumber)
                    .HasMaxLength(15)
                    .HasColumnName("NationalIDNumber");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserInfo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
