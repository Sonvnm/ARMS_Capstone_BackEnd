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
    public class AdmissionInformationConfiguration : IEntityTypeConfiguration<AdmissionInformation>
    {
        public void Configure(EntityTypeBuilder<AdmissionInformation> builder)
        {
            builder.ToTable(nameof(AdmissionInformation));
            builder.HasKey(x => x.AdmissionInformationID);
            builder.Property(x => x.FeeRegister).IsRequired().HasColumnType("decimal(18, 2)"); ;
            builder.Property(x => x.FeeAdmission).IsRequired().HasColumnType("decimal(18, 2)"); ;
            builder.Property(x => x.CampusId).IsRequired();

            #region config relation
            builder.HasOne(x => x.Campus).WithMany(x => x.AdmissionInformations).HasForeignKey(x => x.CampusId).OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}