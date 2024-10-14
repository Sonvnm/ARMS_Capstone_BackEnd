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
    public class MajorConfiguration : IEntityTypeConfiguration<Major>
    {
        public void Configure(EntityTypeBuilder<Major> builder)
        {
            builder.ToTable(nameof(Major));
            builder.Property(x => x.MajorID).IsRequired();
            builder.Property(x => x.MajorName).IsRequired();
            builder.Property(x => x.CampusId).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Tuition).IsRequired();

            #region config relation
            builder.HasOne(x => x.Campus)
                   .WithMany(c => c.Majors)
                   .HasForeignKey(x => x.CampusId);
            #endregion
        }
    }
}