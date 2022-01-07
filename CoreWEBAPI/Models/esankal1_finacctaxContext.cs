using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CoreWEBAPI.Models
{
    public partial class esankal1_finacctaxContext : DbContext
    {
        public esankal1_finacctaxContext()
        {
        }

        public esankal1_finacctaxContext(DbContextOptions<esankal1_finacctaxContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBookConsultation> TblBookConsultations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               
                optionsBuilder.UseSqlServer("Server=103.143.46.143;Database=esankal1_finacctax;User ID=esankal1_finacctax;Password=eSankalp@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("esankal1_finacctax")
                .HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<TblBookConsultation>(entity =>
            {
                entity.ToTable("tbl_BookConsultation", "dbo");

                entity.Property(e => e.AuditAndAccounting)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Audit_and_Accounting");

                entity.Property(e => e.ConsultationDuration)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Consultation_Duration");

                entity.Property(e => e.ScheduleDate)
                    .HasColumnType("date")
                    .HasColumnName("Schedule_Date");

                entity.Property(e => e.SelectConsultant)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Select_Consultant");

                entity.Property(e => e.SelectConsultationMode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Select_Consultation_mode");

                entity.Property(e => e.SelectSubMatter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Select_Sub_Matter");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
