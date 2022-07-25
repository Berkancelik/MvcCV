using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MvcCV.EntiyLayer.Concrete;

#nullable disable

namespace MvcCV.DataAccessLayer.Concrete
{
    public partial class DbCvContext : DbContext
    {
        public DbCvContext()
        {
        }

        public DbCvContext(DbContextOptions<DbCvContext> options)
            : base(options)
        {
        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Hobby> Hobbies { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=DESKTOP-IITT7DV;Initial Catalog=DbCv;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<About>(entity =>
            {
                entity.Property(e => e.Adress).HasMaxLength(250);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(250);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.NameSurname).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(50);
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.Property(e => e.GradeAverage).HasMaxLength(50);

                entity.Property(e => e.SubTitle2).HasMaxLength(50);

                entity.Property(e => e.Subtitle1).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.Property(e => e.Date).HasMaxLength(50);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.Skills).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
