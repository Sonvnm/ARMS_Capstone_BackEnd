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
    public class PayFeeAdmissionConfiguration : IEntityTypeConfiguration<PayFeeAdmission>
    {
        public void Configure(EntityTypeBuilder<PayFeeAdmission> builder)
        {
            builder.ToTable(nameof(PayFeeAdmission));
            builder.HasKey(x => x.Id);

            #region config relation
            builder.HasOne(x => x.StudentProfile)
                   .WithMany(c => c.PayFeeAdmissions)
                   .HasForeignKey(x => x.SpId);
            #endregion
        }
    }
}