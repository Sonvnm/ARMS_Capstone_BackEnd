using Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class StudentConsultationConfiguration : IEntityTypeConfiguration<StudentConsultation>
    {
        public void Configure(EntityTypeBuilder<StudentConsultation> builder)
        {
            builder.ToTable(nameof(StudentConsultation));
            builder.HasKey(x => x.StudentConsultationId);
            builder.Property(x => x.StudentConsultationId)
       .HasDefaultValueSql("NEWID()") 
       .IsRequired();
            builder.Property(x => x.FullName).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.LinkFB).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.DateReceive).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CampusId).IsRequired();
            builder.Property(x => x.MajorID).IsRequired();
            builder.Property(x => x.Notes).IsRequired(false);
            builder.Property(x => x.PhoneNumber).IsRequired();


            #region config relation
            builder.HasOne(x => x.Campus).WithMany(x => x.StudentConsultations).HasForeignKey(x => x.CampusId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Account).WithMany(x => x.StudentConsultations).HasForeignKey(x => x.CreateBy).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Major).WithMany(x => x.StudentConsultations).HasForeignKey(x => x.MajorID).OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}

