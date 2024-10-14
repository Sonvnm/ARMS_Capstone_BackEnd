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
    public class BlogCategoryConfiguration : IEntityTypeConfiguration<BlogCategory>
    {
        public void Configure(EntityTypeBuilder<BlogCategory> builder)
        {
            builder.ToTable(nameof(BlogCategory));
            builder.HasKey(x => x.BlogCategoryId);
            builder.Property(x => x.CampusId).IsRequired();
            builder.Property(x => x.BlogCategoryName).IsRequired();

            #region config relation
            builder.HasOne(x => x.Campus)
                   .WithMany(c => c.BlogCategories)
                   .HasForeignKey(x => x.CampusId);
            #endregion
        }
    }
}
