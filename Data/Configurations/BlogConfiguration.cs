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
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable(nameof(Blog));
            builder.HasKey(x => x.BlogId);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.DateCreate).IsRequired();
            builder.Property(x => x.BlogCategoryId).IsRequired();

            #region config relation
            builder.HasOne(x => x.BlogCategory)
                   .WithMany(c => c.Blogs)
                   .HasForeignKey(x => x.BlogCategoryId);
            #endregion
        }
    }
}
