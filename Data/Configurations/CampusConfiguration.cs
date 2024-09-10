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
    public class CampusConfiguration : IEntityTypeConfiguration<Campus>
    {
        public void Configure(EntityTypeBuilder<Campus> builder)
        {
            builder.ToTable(nameof(Campus));
            builder.Property(x => x.CampusId).IsRequired();
            builder.Property(x => x.CampusName).IsRequired();
            builder.Property(x => x.History).IsRequired(false);
            builder.Property(x => x.TrainingMotto).IsRequired(false);
            builder.Property(x => x.Achievements).IsRequired(false);
            builder.Property(x => x.WhyChooseUs).IsRequired(false);

            #region config relation

            #endregion
        }
    }
}
