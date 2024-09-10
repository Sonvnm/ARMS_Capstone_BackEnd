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
    public class AcademicTranscriptConfiguration : IEntityTypeConfiguration<AcademicTranscript>
    {
        public void Configure(EntityTypeBuilder<AcademicTranscript> builder)
        {
            builder.ToTable(nameof(AcademicTranscript));
            builder.HasKey(x => x.ATId);
            builder.Property(x => x.SpId).IsRequired();
            builder.Property(x => x.SubjectName).IsRequired();
            builder.Property(x => x.SubjectPoint).IsRequired();
            builder.Property(x => x.TypeOfAcademicTranscript).IsRequired();
            #region config relation
            builder.HasOne(x => x.StudentProfile)
                   .WithMany(c => c.AcademicTranscripts)
                   .HasForeignKey(x => x.SpId);

            #endregion

        }
    }
}
