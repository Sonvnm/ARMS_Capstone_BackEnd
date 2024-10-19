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
    public class RequestChangeMajorConfiguration : IEntityTypeConfiguration<RequestChangeMajor>
    {
        public void Configure(EntityTypeBuilder<RequestChangeMajor> builder)
        {
            builder.ToTable(nameof(RequestChangeMajor));
            builder.HasKey(x => x.RequestID);
            builder.Property(x => x.MajorNew).IsRequired();
            builder.Property(x => x.AccountId).IsRequired();
            builder.Property(x => x.DateRequest).IsRequired();
            builder.Property(x => x.FileReasonRequestChangeMajor).IsRequired();
            builder.Property(x => x.Description).IsRequired();

            #region config relation
            builder.HasOne(x => x.Account)
                   .WithMany(c => c.RequestChangeMajors)
                   .HasForeignKey(x => x.AccountId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Campus)
                   .WithMany(c => c.RequestChangeMajors)
                   .HasForeignKey(x => x.CampusId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Major)
                   .WithMany(c => c.RequestChangeMajors)
                   .HasForeignKey(x => x.MajorNew).OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}