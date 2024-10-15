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
    public class AdmissionTimeConfiguration : IEntityTypeConfiguration<AdmissionTime>
    {
        public void Configure(EntityTypeBuilder<AdmissionTime> builder)
        {
            builder.ToTable(nameof(AdmissionTime));
            builder.HasKey(x=>x.AdmissionTimeId);
            builder.Property(x => x.AdmissionTimeName).IsRequired();
            builder.Property(x => x.StartRegister).IsRequired();
            builder.Property(x => x.EndRegister).IsRequired();
            builder.Property(x => x.StartAdmission).IsRequired();
            builder.Property(x => x.EndAdmission).IsRequired();

            #region config relation
            builder.HasOne(x => x.AdmissionInformation).WithMany(x => x.AdmissionTimes).HasForeignKey(x => x.AdmissionInformationID).OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}