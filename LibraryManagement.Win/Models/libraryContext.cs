using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibraryManagement.Win.Models
{
    public partial class libraryContext : DbContext
    {
        public libraryContext()
        {
        }

        public libraryContext(DbContextOptions<libraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tbaction> Tbaction { get; set; }
        public virtual DbSet<Tbbook> Tbbook { get; set; }
        public virtual DbSet<Tbencyclopedia> Tbencyclopedia { get; set; }
        public virtual DbSet<Tbbookwriter> Tbbookwriter { get; set; }
        public virtual DbSet<Tbmagazine> Tbmagazine { get; set; }
        public virtual DbSet<Tbmanager> Tbmanager { get; set; }
        public virtual DbSet<Tbmember> Tbmember { get; set; }
        public virtual DbSet<Tbpenalty> Tbpenalty { get; set; }
        public virtual DbSet<Tbperson> Tbperson { get; set; }
        public virtual DbSet<Tbpublication> Tbpublication { get; set; }
        public virtual DbSet<Tbpublicationtype> Tbpublicationtype { get; set; }
        public virtual DbSet<Tbpublishhome> Tbpublishhome { get; set; }
        public virtual DbSet<Tbrole> Tbrole { get; set; }
        public virtual DbSet<Tbsettings> Tbsettings { get; set; }
        public virtual DbSet<Tbwriter> Tbwriter { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=libraryDb;Username=postgres;Password=ydeC001a");


                /*
                optionsBuilder.UseSqlServer("Server=localhost\\SQLExpress;Database=library;Trusted_Connection=True;");*/
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbaction>(entity =>
            {
                entity.ToTable("tbaction");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PersonId).HasColumnName("personId");

                entity.Property(e => e.PublicationId).HasColumnName("publicationId");
                
                entity.Property(e => e.actionTime)
                    .HasColumnName("actionTime")
                    .HasColumnType("timestamp");

                entity.Property(e => e.actionFinalTime)
                    .HasColumnName("actionFinalTime")
                    .HasColumnType("timestamp");

                entity.Property(e => e.actionEndTime)
                    .HasColumnName("actionEndTime")
                    .HasColumnType("timestamp");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Tbaction)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbaction_tbperson");

                entity.HasOne(d => d.Publication)
                    .WithMany(p => p.Tbaction)
                    .HasForeignKey(d => d.PublicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbaction_tbpublication");
            });

            modelBuilder.Entity<Tbbook>(entity =>
            {
                entity.ToTable("tbbook");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoverText)
                    .IsRequired()
                    .HasColumnName("coverText")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublicationId).HasColumnName("publicationId");

                entity.HasOne(d => d.Publication)
                    .WithMany(p => p.Tbbook)
                    .HasForeignKey(d => d.PublicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbbook_tbpublication");
            });

            modelBuilder.Entity<Tbencyclopedia>(entity =>
            {
                entity.ToTable("tbencyclopedia");

                entity.Property(e => e.Id).HasColumnName("id");

                

                entity.Property(e => e.PublicationId).HasColumnName("publicationId");

                entity.HasOne(d => d.Publication)
                    .WithMany(p => p.Tbencyclopedia)
                    .HasForeignKey(d => d.PublicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbencyclopedia_tbpublication");
            });

            modelBuilder.Entity<Tbbookwriter>(entity =>
            {
                entity.ToTable("tbbookwriter");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.WriterId).HasColumnName("writerId");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Tbbookwriter)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbbookwriter_tbbook");

                entity.HasOne(d => d.Writer)
                    .WithMany(p => p.Tbbookwriter)
                    .HasForeignKey(d => d.WriterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbbookwriter_tbwriter");
            });

            modelBuilder.Entity<Tbmagazine>(entity =>
            {
                entity.ToTable("tbmagazine");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Period).HasColumnName("period");

                entity.Property(e => e.PublicationId).HasColumnName("publicationId");

                entity.Property(e => e.PublishDate)
                    .HasColumnName("publishDate")
                    .HasColumnType("timestamp");

                entity.HasOne(d => d.Publication)
                    .WithMany(p => p.Tbmagazine)
                    .HasForeignKey(d => d.PublicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbmagazine_tbpublication");
            });

            modelBuilder.Entity<Tbmanager>(entity =>
            {
                entity.ToTable("tbmanager");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasColumnName("pass")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("personId");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("userName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Tbmanager)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbmanager_tbperson");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Tbmanager)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbmanager_tbrole");
            });

            modelBuilder.Entity<Tbmember>(entity =>
            {
                entity.ToTable("tbmember");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.PersonId).HasColumnName("personId");

                entity.Property(e => e.RegisterDate)
                    .HasColumnName("registerDate")
                    .HasColumnType("timestamp");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Tbmember)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbmember_tbperson");
            });

            modelBuilder.Entity<Tbpenalty>(entity =>
            {
                entity.ToTable("tbpenalty");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionId).HasColumnName("actionId");

                entity.Property(e => e.PenaltyEndTime)
                    .HasColumnName("penaltyEndTime")
                    .HasColumnType("timestamp");

                entity.Property(e => e.PenaltyTime)
                    .HasColumnName("penaltyTime")
                    .HasColumnType("timestamp");

                entity.Property(e => e.PersonId).HasColumnName("personId");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.Tbpenalty)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbpenalty_tbaction");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Tbpenalty)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbpenalty_tbperson");
            });

            modelBuilder.Entity<Tbperson>(entity =>
            {
                entity.ToTable("tbperson");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbpublication>(entity =>
            {
                entity.ToTable("tbpublication");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClassifcationNumber)
                    .IsRequired()
                    .HasColumnName("classifcationNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PageCount).HasColumnName("pageCount");

                entity.Property(e => e.PublicationTypeId).HasColumnName("publicationTypeId");

                entity.Property(e => e.PublishHomeId).HasColumnName("publishHomeId");

                entity.Property(e => e.RegisterNumber)
                    .IsRequired()
                    .HasColumnName("registerNumber")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.PublicationType)
                    .WithMany(p => p.InversePublicationType)
                    .HasForeignKey(d => d.PublicationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbpublication_tbpublication");

                entity.HasOne(d => d.PublishHome)
                    .WithMany(p => p.Tbpublication)
                    .HasForeignKey(d => d.PublishHomeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbpublication_tbpublishhome");
            });

            modelBuilder.Entity<Tbpublicationtype>(entity =>
            {
                entity.ToTable("tbpublicationtype");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbpublishhome>(entity =>
            {
                entity.ToTable("tbpublishhome");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbrole>(entity =>
            {
                entity.ToTable("tbrole");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Add).HasColumnName("add");

                entity.Property(e => e.BookGive).HasColumnName("bookGive");

                entity.Property(e => e.BookReturn).HasColumnName("bookReturn");

                entity.Property(e => e.Delete).HasColumnName("delete");

                entity.Property(e => e.Edit).HasColumnName("edit");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbsettings>(entity =>
            {
                entity.ToTable("tbsettings");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.LibraryName)
                    .IsRequired()
                    .HasColumnName("libraryName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PublicationCount)
                .IsRequired()
                .HasColumnName("publicationcount");
                entity.Property(e => e.WriterCount)
                .IsRequired()
                .HasColumnName("writercount");


                entity.Property(e => e.ReadDayLimit).HasColumnName("readDayLimit");
            });

            modelBuilder.Entity<Tbwriter>(entity =>
            {
                entity.ToTable("tbwriter");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Biography)
                    .HasColumnName("biography")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PersonId).HasColumnName("personId");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Tbwriter)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbwriter_tbperson");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
