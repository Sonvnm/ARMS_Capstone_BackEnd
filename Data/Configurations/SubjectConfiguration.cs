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
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable(nameof(Subject));
            builder.HasKey(x => new { x.SubjectCode, x.MajorID });
            builder.Property(x => x.SubjectName).IsRequired();
            builder.Property(x => x.SemesterNumber).IsRequired();
            builder.Property(x => x.NumberOfCredits).IsRequired();
            builder.Property(x => x.StudyTime).IsRequired();
            builder.Property(x => x.Note).IsRequired(false);

            #region config relation
            builder.HasOne(x => x.Major).WithMany(x => x.Subjects).HasForeignKey(x => x.MajorID).OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}