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
    public class AdmissionDetailForMajorConfiguration : IEntityTypeConfiguration<AdmissionDetailForMajor>
    {
        public void Configure(EntityTypeBuilder<AdmissionDetailForMajor> builder)
        {
            builder.ToTable(nameof(AdmissionDetailForMajor));
            builder.HasKey(x => x.ADMId);
            builder.Property(x => x.StatusScore).IsRequired();
            builder.Property(x => x.StatusScoreAcademic).IsRequired();
            builder.Property(x => x.TotalScore).IsRequired();
            builder.Property(x => x.TotalScoreAcademic).IsRequired();
            builder.Property(x => x.Year).IsRequired();

            #region config relation
            builder.HasOne(x => x.Major).WithMany(x => x.AdmissionDetailForMajors).HasForeignKey(x => x.MajorID).OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}