using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class TypeAdmissionConfiguration:IEntityTypeConfiguration<TypeAdmission>
    {
        public void Configure(EntityTypeBuilder<TypeAdmission> builder)
        {
            builder.ToTable(nameof(TypeAdmission));
            builder.HasKey(x => new { x.MajorID, x.TypeDiploma, x.AdmissionTimeId });
            builder.Property(x => x.TypeDiploma).IsRequired();
            builder.Property(x => x.TypeOfTranscript).IsRequired(false);

            #region config relation
            builder.HasOne(x => x.MajorAdmission)
                .WithMany(x => x.TypeAdmissions)
                .HasForeignKey(x => new {x.AdmissionTimeId, x.MajorID})
                .OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}
