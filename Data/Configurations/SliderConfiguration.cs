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
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.ToTable(nameof(Slider));
            builder.Property(x => x.SliderId).IsRequired();
            builder.Property(x => x.Img).IsRequired();
            builder.Property(x => x.CampusId).IsRequired();

            #region config relation
            builder.HasOne(x => x.Campus)
                   .WithMany(c => c.Sliders)
                   .HasForeignKey(x => x.CampusId);
            #endregion
        }
    }
}