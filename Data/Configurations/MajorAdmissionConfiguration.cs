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
    public class MajorAdmissionConfiguration : IEntityTypeConfiguration<MajorAdmission>
    {
        public void Configure(EntityTypeBuilder<MajorAdmission> builder)
        {
            builder.ToTable(nameof(MajorAdmission));
            builder.HasKey(x => new { x.AdmissionTimeId, x.MajorID });
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Target).IsRequired();

            #region config relation
            builder.HasOne(x => x.AdmissionTime)
                   .WithMany(c => c.MajorAdmissions)
                   .HasForeignKey(x => x.AdmissionTimeId);
            builder.HasOne(x => x.Major)
                  .WithMany(c => c.MajorAdmissions)
                  .HasForeignKey(x => x.MajorID);
            #endregion
        }
    }
}